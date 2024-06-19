using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour 
{
    public Quest quest;
    public GameObject questWindow;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;


    private void OnTriggerEnter(Collider other)
    {
        questWindow.SetActive(true);
        titleText.text = quest.title;
        descriptionText.text = quest.description;

    }

    private void OnTriggerExit(Collider other)
    {
        questWindow.SetActive(false);
    }
}
