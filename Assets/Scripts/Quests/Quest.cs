[System.Serializable]
public class Quest
{

    //state of quest
    public QuestState state = QuestState.New;

    // name of quest 
    public string name;
    //description
    public string description;
    //experience reward
    public int expReward;
    //gold reward
    public int goldReward;
    //goal
    public QuestGoal goal;
    // complete
    public void Complete()
    {
        state = QuestState.Completed;
    }
    
}

//very nice
public enum QuestState
{
    New,
    Accepted,
    Failed,
    Completed,
    Claimed
}