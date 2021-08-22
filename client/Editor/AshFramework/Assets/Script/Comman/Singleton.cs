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
                //if (Singleton<T>.m_instance != null)
                //{
                //             (Singleton<T>.m_instance as Singleton<T>).Initialize();
                //}
            }

            return Singleton<T>.inst;
        }
    }

    public static void Release()
    {
        if (Singleton<T>.inst != null)
        {
            Singleton<T>.inst = (T)((object)null);
        }
    }

    public virtual void Initialize()
    {

    }

    public abstract void Dispose();

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

                    inst.Initialize();
                }
            }

            return inst;
        }
    }

    public abstract void Initialize();

    private void Awake()
    {
        if (inst == null)
        {
            inst = this as T;
        }

        DontDestroyOnLoad(gameObject);
    }


    public void DestroySelf()
    {
        Dispose();
        SingletonMono<T>.inst = null;
        UnityEngine.Object.Destroy(gameObject);
    }

    public abstract void Dispose();

}