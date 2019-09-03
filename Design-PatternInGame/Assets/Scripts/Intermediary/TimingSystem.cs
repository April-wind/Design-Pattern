using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimingSystem : IGameSystem {
    private Text CountDownText;
    private float timeCount = 15;
    private Intermediary _intermediary;
    private bool isEnd = false;
    public TimingSystem (Intermediary mediator)  {
        this._intermediary = mediator;
        CountDownText = GameObject.Find ("CountDownText").GetComponent<Text> ();
    }
    public  void OnEnd () {
        isEnd = true;
    }
    public  void OnStart () {
        timeCount = 15;
        isEnd = false;
    }
    public  void OnUpdate () {
        if (isEnd) return;
        timeCount -= Time.deltaTime;
        CountDownText.text = ((int) timeCount).ToString ();
        if (timeCount <= 0) {
            _intermediary.End();
        }
    }
}