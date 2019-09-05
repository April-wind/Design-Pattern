using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState {
    public IdleState () {

    }

    public override void Handle (PlayerController playerController) {
        Debug.Log ("我在Idle");
        OnEnter (playerController);
    }

    private void OnEnter (PlayerController playerController) {
        playerController._currentState = this;
        playerController.playerState = PlayerState.Idle;
        Debug.Log ("现在的状态是：" + playerController._currentState);
    }

}