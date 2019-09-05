using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquatState : BaseState {

    public SquatState () {
       
    }
    public override void Handle (PlayerController playerController) {
        Debug.Log ("我在Squat");
        OnEnter(playerController);
    }
    private  void OnEnter (PlayerController playerController) {
        playerController._currentState = this;
        playerController.playerState=PlayerState.Squat;
        Debug.Log ("现在的状态是：" + playerController._currentState);
    }
}