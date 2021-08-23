//////////////////////////////////////////////////////////////////////////////////////////////
/// ����
/// ˵���������������ڵ�һ�����ú����̳�ʼ����Ҳ�����Զ�������Դ
///       ������ʽ�ĵ���Initialize��Release������ʾ��ʼ��������
///       �����ӿ���̳нӿڷֿ���Ϊ�Ժ�ӹ�����׼��
/// ˼·��Ϊ�˱��ⵥ�������ã�����ߵ�����ʹ���ż�
///         1. ��������
///         2. �ڴ��������
///         3. �����ڶ�̬
///         4. ���̵߳�����
///         5. ̫��ĵ������������ռ����
///       �Դ�ʱ�������Լ���ֻ����ͨ�õ�/ȫ�ֵ�/���������Ͽ���ʹ�õ���
///         1. �Ƿ���ȫ�ֵĹ����� (����log)
///         2. �Ƿ���Թ�����������ڣ���ʾ���ó�ʼ��������
///         3. �ж��ٸ����ܵ�ģ��Ҫʹ����
///         4. �ǲ��Ƕ��̣߳�Ҫ��Ҫ����
///         5. ��û�и��õķ���
///             1. ֱ���Լ������Լ�
///             2. �̳���ͬһ�����࣬�������ߵ���������������һ�������ʲ����Ŀ���������һϵ��ui���ࣩ
///             3. ���������global�����������ʲ�����
///             4. ���ú���ʱ����context��������
///             5. ����λ��ģʽ����������ʹ�ò�ͬ���࣬�������ؾ�������
///             6. ��̬��������һ��
/////////////////////////////////////////////////////////////////////////////////////////////

using System;
using UnityEngine;

public abstract class Singleton<T> where T : class, new()
{
    private static T inst;
    public static T Inst
    {
        get
        {
            if (Singleton<T>.inst == null)
            {
                Singleton<T>.inst = Activator.CreateInstance<T>();
                //������ʾ��ʼ��
                //if(Singleton<T>.m_instance != null)
                //{
                //   (Singleton<T>.m_instance as Singleton<T>).Initialize();
                //}
            }

            return Singleton<T>.inst;
        }
    }

    public void Initialize()
    {
        Init();
    }

    public void Release()
    {
        if (inst != null)
        {
            Dispose();
            inst = null;
        }
        else
        {
            Debug.Log("����ȷ�ĵ����ͷ�ʱ��: " + this.ToString());
        }
    }

    protected virtual void Init()
    {

    }

    protected virtual void Dispose()
    {

    }

}

public abstract class SingletonMono<T> : MonoBehaviour where T : SingletonMono<T>
{
    private static T inst = null;

    public static T Inst
    {
        get
        {
            if (inst == null)
            {
                inst = GameObject.FindObjectOfType(typeof(T)) as T;
                if (inst == null)
                {
                    GameObject go = new GameObject(typeof(T).Name);
                    inst = go.AddComponent<T>();
                    GameObject parent = GameObject.Find("Singleton");
                    if (parent == null)
                    {
                        parent = new GameObject("Singleton");
                        GameObject.DontDestroyOnLoad(parent);
                    }
                    if (parent != null)
                    {
                        go.transform.parent = parent.transform;
                    }
                }
            }
            return inst;
        }
    }
    
    private void Awake()
    {
        if (inst == null)
        {
            inst = this as T;
        }

        DontDestroyOnLoad(gameObject);
    }

    public void Initialize()
    {
        Init();
    }

    public void Release()
    {
        if(inst != null)
        {
            Dispose();
            SingletonMono<T>.inst = null;
            UnityEngine.Object.Destroy(gameObject);
        }
        else
        {
            Debug.Log("����ȷ�ĵ����ͷ�ʱ��: " + this.ToString());
        }
    }

    public void DestroySelf()
    {
        
    }

    protected virtual void Init()
    {

    }

    protected virtual void Dispose()
    {

    }

}