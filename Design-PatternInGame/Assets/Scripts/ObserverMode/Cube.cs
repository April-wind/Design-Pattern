using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IObserver<DataType>
{
    public ISubject<DataType> publisher { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        publisher = FindObjectOfType<Ball>();
            
        publisher.actionPublish += Subscriber;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  void Subscriber(DataType data)
    {
        transform.position = Vector3.Lerp(transform.position, data.pos, Time.deltaTime);
    } 
}
