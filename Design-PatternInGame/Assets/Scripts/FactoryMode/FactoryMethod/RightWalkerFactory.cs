using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightWalkerFactory : IWalkerFactory
{
    public virtual IWalker Create()
    {
        return new GameObject().AddComponent<RightWalker>();
    }
}
