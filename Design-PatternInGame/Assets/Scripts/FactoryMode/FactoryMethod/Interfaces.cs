using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 工厂方法比简单工厂多了一层抽象
/// </summary>
public interface IWalker
{
    void Walk(Transform target);
}

public interface IWalkerFactory
{
    IWalker Create();
}
