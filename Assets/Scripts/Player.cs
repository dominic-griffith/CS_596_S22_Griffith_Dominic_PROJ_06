using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public int gold;

    //make list for more quest
    public Quest quest;

    public TextMeshProUGUI goldCounter;

    private void Start()
    {
        gold = 0;
    }

    private void Update()
    {
        goldCounter.text = gold.ToString();
    }

    public void killEnemy()
    {
        if (quest.isActive)
        {
            quest.goal.EnemyKilled();
            if (quest.goal.isReached())
            {
                gold += quest.goldReward;
                quest.Complete();
            }
        }
    }

    public void gatherItem()
    {
        if(quest.isActive)
        {
            quest.goal.ItemCollected();
            if (quest.goal.isReached())
            {
                gold += quest.goldReward;
                quest.Complete();
            }
        }
    }

    public void activateWizard()
    {
        if (quest.isActive)
        {
            quest.goal.ObjectActivated();
            if (quest.goal.isReached())
            {
                gold += quest.goldReward;
                quest.Complete();
            }
        }
    }


}
