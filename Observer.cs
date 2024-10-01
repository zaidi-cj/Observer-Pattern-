using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    Subject subject;
    private void OnThingHappened()
    {
        Debug.Log("observer responds");
    }

    private void Awake()
    {
       
            subject = FindObjectOfType<Subject>();
            subject.ThingHappened += OnThingHappened;
        
    }

    private void OnDestroy()
    {
        
            subject.ThingHappened -= OnThingHappened;
    }
}
