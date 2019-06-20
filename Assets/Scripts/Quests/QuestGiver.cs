using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class QuestUI
{
    public PlayerQuest Player;
    public GameObject questWindow;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI expText;
    public TextMeshProUGUI goldText;
}

public class QuestGiver : MonoBehaviour
{
    public Quest quest;
    public QuestUI uI;
    public void OpenQuestWindow()
    {
        uI.questWindow.SetActive(true);

        uI.nameText.text = quest.name;
        uI.descriptionText.text = quest.description;
        uI.expText.text = ("Exp ") +quest.expReward.ToString();
        uI.goldText.text = ("Gold ") + quest.goldReward.ToString();
    }
  public void AcceptQuest()
    {
        uI.questWindow.SetActive(false);
        if (quest.state == QuestState.New)
        {
            quest.state = QuestState.Accepted;
            uI.Player.quests.Add(quest);
        }
    }
    public void DeclineQuest()
    {
        uI.questWindow.SetActive(false);
    }
}
