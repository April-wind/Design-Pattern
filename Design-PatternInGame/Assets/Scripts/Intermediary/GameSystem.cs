using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameSystem
{
    void OnStart();
    void OnUpdate();
    void OnEnd();
}
