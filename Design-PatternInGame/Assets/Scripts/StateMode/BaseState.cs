using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public abstract class BaseState{
    public abstract void Handle(PlayerController playerController);
}