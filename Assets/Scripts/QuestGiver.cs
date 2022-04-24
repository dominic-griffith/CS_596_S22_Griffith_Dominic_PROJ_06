using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestGiver : MonoBehaviour
{
    public List<Quest> quest;

    public Player player;

    public GameObject questWindow;

    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI goldText;

    public void OpenQuestWindow()
    {
        questWindow.SetActive(true);

        if(!quest[0].isCompleted && !quest[0].isCanceled)
        {
            titleText.text = quest[0].title;
            descriptionText.text = quest[0].description;
            goldText.text = quest[0].goldReward.ToString();
        }
        else if (!quest[1].isCompleted && !quest[1].isCanceled)
        {
            titleText.text = quest[1].title;
            descriptionText.text = quest[1].description;
            goldText.text = quest[1].goldReward.ToString();
        }
        else if (!quest[2].isCompleted && !quest[2].isCanceled)
        {
            titleText.text = quest[2].title;
            descriptionText.text = quest[2].description;
            goldText.text = quest[2].goldReward.ToString();
        }
        else
        {

        }
    }

    public void CloseQuestWindow()
    {
        questWindow.SetActive(false);
    }

    public void AcceptQuest()
    {
        questWindow.SetActive(false);
        if (!quest[0].isCompleted && !quest[0].isCanceled)
        {
            quest[0].isActive = true;
            player.quest = quest[0];
        }
        else if (!quest[1].isCompleted && !quest[1].isCanceled)
        {
            quest[1].isActive = true;
            player.quest = quest[1];
        }
        else if (!quest[2].isCompleted && !quest[2].isCanceled)
        {
            quest[2].isActive = true;
            player.quest = quest[2];
        }
        else
        {

        }

    }
}
