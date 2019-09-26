using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ConcreteAggregate a = new ConcreteAggregate();

        a[0] = "大鸟";
        a[1] = "小菜";
        a[2] = "行李";
        
        Iterator i = new ConcreteIterator(a);

        object item = i.First();
        while (!i.IsDone())
        {
            Debug.Log(i.CurrentItem() + "来了");
            i.Next();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
