using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : BaseState
{
    public RunState()
    {
        
    }

    public override void Handle(PlayerController playerController)
    {
        Debug.Log("我Run");
        OnEnter(playerController);
    }
    private  void OnEnter(PlayerController playerController)
    { 
        playerController._currentState=this;
        playerController.playerState=PlayerState.Run;
        Debug.Log("现在的状态是："+playerController._currentState);
    }

}