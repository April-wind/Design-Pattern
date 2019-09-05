using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : BaseState {
    public JumpState()
    {
    }

    public override void Handle (PlayerController playerController) {
        Debug.Log ("我在Jump");
        OnEnter(playerController);
    }
    private  void OnEnter (PlayerController playerController) {
        playerController._currentState = this;
        playerController.playerState=PlayerState.Jump;
        Debug.Log ("现在的状态是：" + playerController._currentState);
    }

}