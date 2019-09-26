using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWalkerFactory : IWalkerFactory
{
    public virtual IWalker Create()
    {
        return new GameObject().AddComponent<LeftWalker>();
    }
}
