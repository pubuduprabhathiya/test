using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Subject subject;
    // Start is called before the first frame update
    void Start()
    {
        subject = new Subject();
        subject.head = new Animation();
        subject.addObserver(new Audio());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void fire() {
        Debug.Log("fire");
        subject.notify(this, new ObserverEvent { name = "fire" });
    }

    internal void move()
    {
        Debug.Log("move");
        transform.position = transform.position + Vector3.forward;
       // subject.notify(this, new ObserverEvent { name = "move" });
    }

    
}
