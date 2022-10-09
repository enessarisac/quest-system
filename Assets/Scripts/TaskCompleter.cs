using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskCompleter : MonoBehaviour
{
    public string QuestName;
    public string TaskName;
    public void CompleteTask()
    {
        QuestManager.Instance.CompleteTask(QuestName, TaskName);
    }
}
