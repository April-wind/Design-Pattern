using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 非monobehavior下的单例模式
/// </summary>
public sealed class Singleton
{
    private static Singleton _instance;
    /*进程锁*/
    private static object synRoot = new object();

    private Singleton(){}
    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (synRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }
    }
}
