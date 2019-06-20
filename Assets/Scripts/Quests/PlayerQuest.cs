using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerQuest : MonoBehaviour
{
    public int gold;
    public int experience;
    public Quest quest;

    public List<Quest> quests = new List<Quest>(); 

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < quests.Count; i++)
        {
            if (quests[i].goal.IsReached())
            {
                quests[i].Complete();
                gold = quest.goldReward;
                experience = quest.expReward;
            }
        }
    }
}
