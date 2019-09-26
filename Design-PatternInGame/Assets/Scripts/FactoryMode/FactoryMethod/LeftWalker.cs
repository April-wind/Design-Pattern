using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWalker : MonoBehaviour, IWalker
{
    Transform _target;
    public virtual void Walk(Transform target){
        _target = target;
        StartCoroutine(WalkLeft());
    }

    IEnumerator WalkLeft(){
        while(true){
            _target.Translate(Vector3.right * Time.deltaTime);
            Debug.Log("WalkRight " + _target.localPosition);
            yield return new WaitForFixedUpdate();
        }
    }
}
