using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static QuestManager Instance;
    public List<Quest> ActiveQuests;
    public List<Quest> CompletedQuests;
    private void Awake()
    {
        Instance = this;
    }
    public void StartQuest(Quest quest)
    {
        Debug.Log("Quest started quest name is : " + quest.QuestName);
        quest.StartQuest();
        ActiveQuests.Add(quest);
        QuestUIManager.Instance.AddNewRowToQuest(quest.QuestName);
    }
    public void CompleteTask(string questName,string taskName)
    {
        foreach (var quest in ActiveQuests)
        {
            if (quest.QuestName.Equals(questName))
            {
                quest.CompleteTask(taskName);
                break;
            }
        }
    }
    public void OnQuestCompleted(Quest quest)
    {
        Debug.Log("Quest completed quest name is : " + quest.QuestName);
        ActiveQuests.Remove(quest);
        CompletedQuests.Add(quest);
    }
    
}
