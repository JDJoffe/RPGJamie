[System.Serializable]

public class QuestGoal
{
    //goal type
    public GoalType goalType;
    //required amount
    public int requiredAmount;
    //currentAmount
    public int currentAmount;

    //isReached
    public bool IsReached()
    {
        return (currentAmount >= requiredAmount);
    }
    //enemyKilled
    public void EnemyKilled()
    {
        if (goalType == GoalType.Kill)
        {
            currentAmount++;
        }
    }
    //objectCollected
    public void ObjectCollected()
    {
        if (goalType == GoalType.Gather)
        {
            currentAmount++;
        }
    }

}
public enum GoalType
{
    Kill,
    Gather

}
