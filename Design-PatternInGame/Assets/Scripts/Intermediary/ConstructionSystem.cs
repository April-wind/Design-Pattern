using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ConstructionSystem : IGameSystem {
    private Intermediary _intermediary;
    public List<GameObject> gameobjectList = new List<GameObject> ();
    public ConstructionSystem (Intermediary Intermediary) {
        this._intermediary = Intermediary;
    }

    private GameObject BuildGameObject () {
        Vector3 temp = Camera.main.ScreenToWorldPoint (
            new Vector3 (Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
        temp = new Vector3 (temp.x, 3, 0);

        GameObject obj = MonoBehaviour.Instantiate (Resources.Load<GameObject> ("CubePrefab"));
        obj.transform.position = temp;

        gameobjectList.Add (obj);

        return obj;
    }
    public void OnEnd () {
        for (int i = 0; i < gameobjectList.Count; i++) {
            // gameobjectList[i].gameObject.SetActive (false);
            gameobjectList[i].GetComponent<Rigidbody> ().Sleep ();
        }

    }
    public void OnStart () {
    
        for (int i = 0; i < gameobjectList.Count; i++) {
            gameobjectList[i].gameObject.SetActive (false);
        }
        gameobjectList.Clear ();
    }

    public void OnUpdate () {
        GameObject obj = null;
        if (Input.GetMouseButtonDown (0)) {
            obj = BuildGameObject ();
        }
        if (obj != null) {
            if (obj.transform.position.y < -6) {
                Debug.Log ("超出");
            }
        }
    }
}