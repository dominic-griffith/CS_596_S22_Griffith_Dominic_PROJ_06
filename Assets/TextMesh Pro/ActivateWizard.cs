using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateWizard : MonoBehaviour
{
    public GameObject promptWindow;
    public GameObject activatePromptWindow;
    public GameObject wizardDialog;
    public Player player;

    private bool keyPressed = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && player.quest.goal.goalType == GoalType.Activate)
        {
            promptWindow.SetActive(true);
            if (player.quest.goal.goalType == GoalType.Activate)
            {
                activatePromptWindow.SetActive(true);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" & !keyPressed)
        {
            if (Input.GetKeyDown(KeyCode.E) && player.quest.goal.goalType == GoalType.Activate)
            {
                player.activateWizard();
                keyPressed = true;

                wizardDialog.SetActive(true);

                promptWindow.SetActive(false);
                activatePromptWindow.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            promptWindow.SetActive(false);
            activatePromptWindow.SetActive(false);
            wizardDialog.SetActive(false);
        }
    }
}
