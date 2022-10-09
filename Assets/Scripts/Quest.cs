using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
[System.Serializable]
public class Quest
{
    public QuestState QuestState;
    public string QuestName;
    public string QuestDescription;
    public List<Task> Tasks;
    public QuestRewardType QuestRewardType;
    private Task CurrentTask;
    private int CurrentTaskIndex = 0;
    public GameObject QuestGiver;
    public void StartQuest()
    {
        Debug.Log("Quest In Progress");
        QuestState = QuestState.InProgress;
        CurrentTask = Tasks[CurrentTaskIndex];
    }
    [Button]
    public void CompleteTask(string taskName)
    {
        if (CurrentTask == null)
        {
            Debug.Log("No task to complete");
            return;
        }
        if (!taskName.Equals(CurrentTask.TaskName)) return;
        Task task = FindTask(taskName);
        if (task == null) return;
        task.IsCompleted = true;

        Debug.Log(taskName + " completed");
        CurrentTaskIndex++;
        if (CurrentTaskIndex >= Tasks.Count)
        {
            CompleteQuest();
        }
        else
        {
            CurrentTask = Tasks[CurrentTaskIndex];
            Debug.Log("new task is : " + CurrentTask.TaskName);
        }
    }
    public Task FindTask(string taskName)
    {
        foreach (var task in Tasks)
        {
            if (task.TaskName.Equals(taskName))
            {
                return task;
            }
        }
        return null;
    }
    public void CompleteQuest()
    {
        QuestState = QuestState.Completed;
        QuestManager.Instance.OnQuestCompleted(this);
        QuestGiver.GetComponent<QuestGiver>().CompleteQuest();
    }

}
