using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiverInteractable : MonoBehaviour, ITriggerEnter, ITriggerStay,ITriggerExit
{
    private QuestGiver questGiver;
    [SerializeField] KeyCode interactKey = KeyCode.E;
    private void Awake()
    {
        questGiver = GetComponentInParent<QuestGiver>();
    }
    public void OnEnter(GameObject player, GameObject gameObject)
    {
        if (questGiver == null) return;
        if(interactKey != KeyCode.None) QuestUIManager.Instance.OpenInteractUI(); 
        Debug.Log("Quest giver interactable");
    }

    public void OnStay(GameObject player, GameObject gameObject)
    {
        if (questGiver == null) return;
        Debug.Log("Quest giver interactable");
        if (Input.GetKey(interactKey))
        {
            questGiver.GiveQuest();
            QuestUIManager.Instance.CloseInteractUI();
        }
    }

    public void OnExit(GameObject player, GameObject gameObject)
    {
        if(questGiver == null) return;
        if(interactKey != KeyCode.None) QuestUIManager.Instance.CloseInteractUI(); 
    }
}

