using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 泛型类实现单例模式 避免了重复的代码
/// </summary>
/// <typeparam name="T"></typeparam>
/// ***最大的坑是单例的monobehaviour，其生命周期并非我们程序员可以控制的。
/// ***MonoBehaviour本身的Destroy，将会决定单例类的实例在何时销毁。因此，一定不要在OnDestroy函数中调用单例对象，
/// ***这可能导致该对象在游戏结束后依然存在（原本的单例类已经销毁了，你又创建了一个新的，当然就不会再销毁一次了）

public class SingleTemplate<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;
    /*进程锁*/
    private static object synRoot = new Object();

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                lock (synRoot)
                {
                    if (instance == null)
                    {
                        T[] instances = (T[]) FindObjectsOfType(typeof(T));
                        if (instance != null)
                        {
                            for (var i = 0; i < instances.Length; i++)
                            {
                                Destroy(instances[i].gameObject);
                            }
                        }
                        
                        GameObject go = new GameObject();
                        go.name = typeof(T).Name;
                        instance = go.AddComponent<T>();
                        DontDestroyOnLoad(go);
                    }
                }
            }

            return instance;
        }
    }
}
