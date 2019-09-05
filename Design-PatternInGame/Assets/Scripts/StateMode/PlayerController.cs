using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PlayerState {
    Idle, //站立状态
    Jump, //跳跃状态
    Run, //奔跑状态
    Squat //下蹲状态
}
public class PlayerController : MonoBehaviour {
    public BaseState _currentState;
    public PlayerState playerState;
    private BaseState idleState;
    private BaseState jumpState;
    private BaseState runState;
    private BaseState squatState;

    public Text text;
    void Start () {
        //默认的状态为Idle状态	
        idleState = new IdleState ();
        jumpState = new JumpState ();
        runState = new RunState ();
        squatState = new SquatState ();

        _currentState = new IdleState ();
        playerState = PlayerState.Idle;
    }
    void Update () {
        switch (playerState) {
            case PlayerState.Idle:
                text.text = "idle";
                if (Input.GetKeyDown (KeyCode.Space)) 
                { _currentState = jumpState; _currentState.Handle (this); }
                if (Input.GetKeyDown (KeyCode.LeftControl)) 
                { _currentState = squatState; _currentState.Handle (this); }
                if (Input.GetAxis ("Horizontal") != 0) 
                { _currentState = runState; _currentState.Handle (this); }
                break;
            case PlayerState.Jump:
                text.text = "jump";
                if (!Input.GetKey (KeyCode.Space)) 
                { _currentState = idleState; _currentState.Handle (this); }
                break;
            case PlayerState.Run:   
                text.text = "run";
                if (Input.GetKeyDown (KeyCode.Space)) 
                { _currentState = jumpState; _currentState.Handle (this); }
                if (Input.GetKeyDown (KeyCode.LeftControl)) 
                { _currentState = squatState; _currentState.Handle (this); }
                if (Input.GetAxis ("Horizontal") == 0) 
                { _currentState = idleState; _currentState.Handle (this); }
                break;
            case PlayerState.Squat:
                text.text = "squat";
                if (!Input.GetKey (KeyCode.LeftControl)) 
                { _currentState = idleState; _currentState.Handle (this); }
                break;
        }
    }
}