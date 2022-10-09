using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public List<Quest> Quest = new List<Quest>();
    [SerializeField] private int currentQuestIndex = 0;

    [Button]
    public void GiveQuest()
    {
        if(currentQuestIndex >= Quest.Count) return;
        if (Quest[currentQuestIndex].QuestState == QuestState.Inactive)
        {
            Debug.Log("Quest given");
            Quest[currentQuestIndex].QuestGiver = gameObject;
            QuestManager.Instance.StartQuest(Quest[currentQuestIndex]);
        }
    }
    public void CompleteQuest()
    {
        currentQuestIndex++;
    }
}