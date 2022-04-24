using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public GameObject promptWindow;
    public GameObject gatherPromptWindow;
    public Player player;

    private bool keyPressed = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && player.quest.goal.goalType == GoalType.Gather)
        {
            promptWindow.SetActive(true);
            if (player.quest.goal.goalType == GoalType.Gather)
            {
                gatherPromptWindow.SetActive(true);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" & !keyPressed)
        {
            if (Input.GetKeyDown(KeyCode.E) && player.quest.goal.goalType == GoalType.Gather)
            {
                player.gatherItem();
                keyPressed = true;
                Destroy(transform.parent.gameObject);
                promptWindow.SetActive(false);
                gatherPromptWindow.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            promptWindow.SetActive(false);
            gatherPromptWindow.SetActive(false);
        }
    }
}
