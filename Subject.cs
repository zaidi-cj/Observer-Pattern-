using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{

    public event Action ThingHappened;
    public void DoThing()
    {
        ThingHappened?.Invoke();
    }
    private void OnTriggerEnter(Collider other)
    {
        DoThing();
    }
}
