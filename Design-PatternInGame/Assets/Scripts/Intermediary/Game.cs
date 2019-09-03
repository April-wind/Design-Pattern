using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {
    Gameing,
    GamePause,
    GameEnd
}

public class Game : MonoBehaviour {
    public Intermediary _Intermediary;
    void Awake () {
        _Intermediary = new Intermediary();

        _Intermediary.Init ();
    }

    void Start () {
        _Intermediary.Start ();
    }
    void Update () {
        if (_Intermediary.gameState == GameState.GameEnd) {
            if (Input.GetKeyDown (KeyCode.Space)) {
                _Intermediary.Start ();
            }
        }
        if (_Intermediary.gameState!=GameState.Gameing)return;
        _Intermediary.Update ();
    }
}