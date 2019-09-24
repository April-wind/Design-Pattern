using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonobehavior : MonoBehaviour
{
    private static SingletonMonobehavior instance;
    /*进程锁*/
    private static object synRoot = new object();

    public static SingletonMonobehavior Instance
    {
        get
        {
            if (instance == null)
            {
                lock (synRoot)
                {
                    if (instance == null)
                    {
                        //判断场景中是否只有一个实例

                        SingletonMonobehavior[] instances =
                            (SingletonMonobehavior[]) FindObjectsOfType(typeof(SingletonMonobehavior));

                        if (instance != null)
                        {
                            //如果因为切换场景使得实例不止一个, 遍历完全部删除
                                
                            for (var i = 0; i < instances.Length; i++)
                            {
                                Destroy(instances[i].gameObject);
                            }
                        }
                        //删除完在创建出新的唯一的实例
                        
                        GameObject go = new GameObject("SingletonObject");
                        instance = go.AddComponent<SingletonMonobehavior>();
                        DontDestroyOnLoad(go);
                    }
                }
            }

            return instance;
        }
    }
    
}
