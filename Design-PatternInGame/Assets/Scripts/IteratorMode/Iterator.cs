using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 迭代器抽象类
/// </summary>
public abstract class Iterator
{
    /// <summary>
    /// 开始对象
    /// </summary>
    /// <returns></returns>
    public abstract object First();
    /// <summary>
    /// 下一个对象
    /// </summary>
    /// <returns></returns>
    public abstract object Next();
    /// <summary>
    /// 判断是否到结尾
    /// </summary>
    /// <returns></returns>
    public abstract bool IsDone();
    /// <summary>
    /// 当前对象
    /// </summary>
    /// <returns></returns>
    public abstract object CurrentItem();
}

/// <summary>
/// 聚集抽象类
/// </summary>
abstract class Aggregate
{
    /// <summary>
    /// 创建迭代器
    /// </summary>
    /// <returns></returns>
    public abstract Iterator CreateIterator();
}
