using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IProduct
{
    void DoSth();
}

public class ProductOne : IProduct
{
    public virtual void DoSth()
    {
        Debug.Log("One");
    }
}
public class ProductTwo : IProduct
{
    public virtual void DoSth()
    {
        Debug.Log("Two");
    }
}
    
/// <summary>
/// 简单工厂模式
/// </summary>
public class SimpleFactory 
{
    public static IProduct Create(int id)
    {
        switch (id)
        {
            case 1 : return new ProductOne(); break;
            case 2 : return new ProductTwo(); break;
            default: return null; break;
        }
    }
}
