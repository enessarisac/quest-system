using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTaskCompleter : MonoBehaviour, ITriggerEnter
{
    public void OnEnter(GameObject player, GameObject gameObject)
    {
        var TaskCompleter = gameObject.GetComponent<TaskCompleter>();
        if(TaskCompleter == null)
        {
            TaskCompleter = gameObject.GetComponentInParent<TaskCompleter>();
        }
        TaskCompleter.CompleteTask();
    }
}
