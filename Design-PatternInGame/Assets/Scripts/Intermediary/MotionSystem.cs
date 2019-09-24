using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 运动系统
/// </summary>
public class MotionSystem : MonoBehaviour, IGameSystem
{
    //中介者
    private Intermediary _intermediary;
    
    private Transform floorTransform;
    private float speed = 2;

    public MotionSystem(Intermediary intermediary)
    {
        this._intermediary = intermediary;
        floorTransform = GameObject.Find ("Floor").transform;
    }
    
    public  void OnEnd () 
    {
        floorTransform.GetComponent<Rigidbody> ().velocity = Vector2.zero;
    }
    
    public  void OnStart () 
    {
        floorTransform.GetComponent<Rigidbody> ().velocity = new Vector3 (speed * 1, 0, 0);
    }
    
    public  void OnUpdate () 
    {
        if (floorTransform != null) 
        {

            if (Camera.main.WorldToViewportPoint (floorTransform.transform.position).x >= 1) 
            {
                floorTransform.GetComponent<Rigidbody> ().velocity = new Vector3 (speed * -1, 0, 0);
            }
            if (Camera.main.WorldToViewportPoint (floorTransform.transform.position).x <= 0) 
            {
                floorTransform.GetComponent<Rigidbody> ().velocity = new Vector3 (speed * 1, 0, 0);
            }
            
        }
    }
}
