using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuestLog : MonoBehaviour
{
    public GameObject questLogWindow;

    public QuestGiver possibleQuest;

    public TextMeshProUGUI killState;
    public TextMeshProUGUI gatherState;
    public TextMeshProUGUI activateState;

    public Button killCancel;
    public Button gatherCancel;
    public Button activateCancel;

    private bool questLogOpen = false;

    private void Update()
    {

        if (possibleQuest.quest[0].isActive)
        {
            killState.text = "In progress";
        }
        if(possibleQuest.quest[0].isCompleted && !possibleQuest.quest[1].isActive && !possibleQuest.quest[1].isCompleted && !possibleQuest.quest[1].isCanceled)
        {
            if(!possibleQuest.quest[0].isCanceled)
                killState.text = "Done";
            gatherState.text = "Unlocked";
        }
        if (possibleQuest.quest[1].isActive)
        {
            gatherState.text = "In progress";
        }
        if (possibleQuest.quest[1].isCompleted && !possibleQuest.quest[2].isActive && !possibleQuest.quest[2].isCompleted && !possibleQuest.quest[2].isCanceled)
        {
            if(!possibleQuest.quest[1].isCanceled)
                gatherState.text = "Done";
            activateState.text = "Unlocked";
        }
        if (possibleQuest.quest[2].isActive)
        {
            activateState.text = "In progress";
        }
        if (possibleQuest.quest[2].isCompleted && !possibleQuest.quest[2].isCanceled)
        {
            activateState.text = "Done";
        }

        if (Input.GetKeyDown(KeyCode.Q) && !questLogOpen)
        {
            questLogWindow.SetActive(true);
            questLogOpen = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && questLogOpen)
        {
            questLogWindow.SetActive(false);
            questLogOpen = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        if(possibleQuest.quest[0].isActive)
        {
            killCancel.interactable = true;

        }
        else
        {
            killCancel.interactable = false;
        }
        if (possibleQuest.quest[1].isActive)
        {
            gatherCancel.interactable = true;

        }
        else
        {
            gatherCancel.interactable = false;
        }
        if (possibleQuest.quest[2].isActive)
        {
            activateCancel.interactable = true;

        }
        else
        {
            activateCancel.interactable = false;
        }
    }

    public void cancelKillQuest()
    {
        killState.text = "Canceled";
        gatherState.text = "Unlocked";
        possibleQuest.quest[0].isCanceled = true;
        possibleQuest.quest[0].isActive = false;
    }

    public void cancelGatherQuest()
    {
        gatherState.text = "Canceled";
        activateState.text = "Unlocked";
        possibleQuest.quest[1].isCanceled = true;
        possibleQuest.quest[1].isActive = false;
    }

    public void cancelActivateQuest()
    {
        activateState.text = "Canceled";
        possibleQuest.quest[2].isCanceled = true;
        possibleQuest.quest[2].isActive = false;
    }
}
