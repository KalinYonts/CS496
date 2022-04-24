using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class QuestGoal 
{
    public GoalType goalType;
    public int requiredAmount;
    public int currentAmount;

    public Text ReqAmt;
    public Text CurAmt;


    public bool IsReached() 
    {
        return (currentAmount >= requiredAmount);
    }

    public void EnemyKilled()
    {
        if (goalType == GoalType.Kill)
        currentAmount++;
    }
    public void ItemCollected()
    {
        if (goalType == GoalType.Gathering)
        currentAmount++;
        DisplayProgress();
    }

    public void DisplayProgress()
    {
        ReqAmt.text = requiredAmount.ToString();
        CurAmt.text = currentAmount.ToString();
    }

    void Update()
    {
        DisplayProgress();
    }
}
public enum GoalType 
{
    Kill,
    Gathering
}
