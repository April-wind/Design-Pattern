using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ConcreteIterator : Iterator
{
    /*具体聚集对象*/
    private ConcreteAggregate _aggregate;
    private int current = 0;

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this._aggregate = aggregate;
    }

    /// <summary>
    /// 获得聚集的第一个对象
    /// </summary>
    /// <returns></returns>
    public override object First()
    {
        return _aggregate[0];
    }

    /// <summary>
    /// 获得聚集的下一个对象
    /// </summary>
    /// <returns></returns>
    public override object Next()
    {
        object ret = null;
        current++;
        if (current < _aggregate.Count)
        {
            ret = _aggregate[current];
        }

        return ret;
    }

    /// <summary>
    /// 判断是否遍历到结尾
    /// </summary>
    /// <returns></returns>
    public override bool IsDone()
    {
        return current >= _aggregate.Count ? true : false;
    }

    /// <summary>
    /// 返回当前聚集对象
    /// </summary>
    /// <returns></returns>
    public override object CurrentItem()
    {
        return _aggregate[current];
    }
}
