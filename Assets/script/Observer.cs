using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Observer 
{
    internal Observer next { get; set; }

    public Observer() {
        next = null;
    }
   
    internal virtual void onNotify(object sender, ObserverEvent e) { 
    
    }
}
public class ObserverEvent { 
    public string name { get; set; }
}
public class Animation : Observer {

    Animator animator { get; set; }
    override
    internal  void onNotify(object sender, ObserverEvent e)
    {
        Debug.Log($"play animation {e.name}");
    }
}

public class Audio : Observer
{

    override
    internal void onNotify(object sender, ObserverEvent e)
    {
        audioManage.instance.play(e.name);
        Debug.Log($"play audio {e.name}");
    }
}