using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountSystem : IGameSystem {
    private Text scoreText;

    private int currentCount = 0;
    private Intermediary _intermediary;

    public CountSystem (Intermediary intermediary) {
        this._intermediary = intermediary;
        scoreText = GameObject.Find ("CountText").GetComponent<Text> ();
    }
    public int CurrentCount {
        get { return currentCount; }
    }
    public void OnUpdate () {
		
    }
    public void OnEnd () {
        for (int i = 0; i < _intermediary.constructionSystem.gameobjectList.Count; i++)
        {
            if (_intermediary.constructionSystem.gameobjectList[i].transform.position.y>-3){
                currentCount++;
            }
        }
        scoreText.text = "当前总数：" + currentCount.ToString () + "\n"+"按空格重新开始";
    }
    public void OnStart () {
        currentCount = 0;
        scoreText.text = currentCount.ToString ();
    }
}