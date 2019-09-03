using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct DataType
{
    public Vector3 pos;
}
public class Ball : MonoBehaviour, ISubject<DataType>
{
    public DataType dataType = new DataType {pos = Vector3.zero};
    public Action<DataType> actionPublish { get; set; }

    public void Publisher()
    {
        if (actionPublish != null)
        {
            actionPublish(dataType);
        }
    }
    // Update is called once per frame
    void Update()
    {
        dataType.pos = transform.position;
        Publisher();
    }
}
