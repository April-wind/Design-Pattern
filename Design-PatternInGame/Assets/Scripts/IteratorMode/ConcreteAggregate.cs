using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 具体聚集类
/// </summary>
class ConcreteAggregate : Aggregate
{
    /*声明一个IList泛型变量，用于存放聚合对象*/
    private IList<object> items = new List<object>();

    public override Iterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    /*聚集总个数*/
    public int Count
    {
        get { return items.Count; }
    }

    /*索引器*/
    public object this[int index]
    {
        get { return items[index]; }
        set { items.Insert(index, value); }
    }
}
