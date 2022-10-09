using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        var IEnter = other.GetComponent<ITriggerEnter>();
        if(IEnter == null) return;
        IEnter.OnEnter(gameObject,other.gameObject);
        
    }
    private void OnTriggerStay(Collider other) 
    {
        var IStay = other.GetComponent<ITriggerStay>();
        if(IStay == null) return;
        IStay.OnStay(gameObject,other.gameObject);
    }
    private void OnTriggerExit(Collider other) 
    {
        var IExit = other.GetComponent<ITriggerExit>();
        if(IExit == null) return;
        IExit.OnExit(gameObject,other.gameObject);
    }
    
}

