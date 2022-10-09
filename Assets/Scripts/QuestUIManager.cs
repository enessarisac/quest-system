using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class QuestUIManager : MonoBehaviour
{
    public static QuestUIManager Instance;
    public GameObject scrollView;
    public GameObject questUI;
    public GameObject InteactUI;
    private void Awake()
    {
        Instance = this;
    }
    public void OpenInteractUI()
    {
        InteactUI.SetActive(true);
    }
    public void CloseInteractUI()
    {
        InteactUI.SetActive(false);
    }
    public void AddNewRowToQuest(string questName)
    {
        GameObject newQuest = Instantiate(questUI, scrollView.transform);
        newQuest.GetComponentInChildren<TextMeshProUGUI>().text = questName;
    }
}
