using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 发布者接口
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ISubject<T>
{
    Action<T> actionPublish { get; set; }
}

/// <summary>
/// 观察者接口
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IObserver<T>
{
    ISubject<T> publisher { get; set; }
    void Subscriber(T data);
}
