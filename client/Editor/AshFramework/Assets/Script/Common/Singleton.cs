//////////////////////////////////////////////////////////////////////////////////////////////
/// 单例
/// 说明：本单例不会在第一次引用后立刻初始化，也不会自动销毁资源
///       必须显式的调用Initialize和Release进行显示初始化和销毁
///       公共接口与继承接口分开，为以后加功能做准备
/// 思路：为了避免单例被滥用，故提高单例的使用门槛
///         1. 依赖混乱
///         2. 内存回收问题
///         3. 不利于多态
///         4. 多线程的灾难
///         5. 太多的单例会让命名空间混乱
///       以此时刻提醒自己，只能在通用的/全局的/纯工具类上考虑使用单例
///         1. 是否是全局的工具类 (比如log)
///         2. 是否可以管理好生命周期，显示调用初始化和销毁
///         3. 有多少个可能的模块要使用它
///         4. 是不是多线程，要不要加锁
///         5. 有没有更好的方法
///             1. 直接自己管理自己
///             2. 继承自同一个基类，而不是走单例管理器（比如一个外界访问不到的控制器管理一系列ui基类）
///             3. 单例类放在global类下面来访问并管理
///             4. 调用函数时包在context里来处理
///             5. 服务定位器模式，根据需求使用不同的类，对外隐藏具体内容
///             6. 静态方法考虑一下
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
                //必须显示初始化
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
            Debug.Log("不正确的单例释放时机: " + this.ToString());
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
            Debug.Log("不正确的单例释放时机: " + this.ToString());
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