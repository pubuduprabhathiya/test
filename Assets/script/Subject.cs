using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject 
{
    internal Observer head;
   
    internal void notify(object sender, ObserverEvent e)
    {
        Observer observer = head;
        while (observer != null)
        {
            observer.onNotify(sender, e);
            observer = observer.next;
        }
    }

    internal void addObserver(Observer observer)
    {
        observer.next = head;
        head = observer;
    }
}
