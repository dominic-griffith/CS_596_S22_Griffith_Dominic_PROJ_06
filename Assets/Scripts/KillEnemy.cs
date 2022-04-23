using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    public GameObject promptWindow;
    public GameObject killPromptWindow;
    public Player player;

    private bool keyPressed = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            promptWindow.SetActive(true);
            if(player.quest.goal.goalType == GoalType.Kill)
            {
                killPromptWindow.SetActive(true);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" & !keyPressed)
        {
            if (Input.GetKeyDown(KeyCode.E) && player.quest.goal.goalType == GoalType.Kill)
            {
                player.killEnemy();
                keyPressed = true;
                Destroy(transform.parent.gameObject);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            promptWindow.SetActive(false);
            killPromptWindow.SetActive(false);
        }
    }
}
