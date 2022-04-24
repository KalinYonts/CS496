using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
   public Quest quest;
   public QuestGoal goal;
   public Player player;
    public GameObject questWindow;
    public GameObject questStart;
    public GameObject questProgress;
    public Text titleText;
    public Text descriptionText;
    public Text experienceText;
    public Text goldText;


   public void OpenQuestWindow() {
       questStart.SetActive(false);
       questWindow.SetActive(true);
       titleText.text = quest.title;
       descriptionText.text = quest.description;
       experienceText.text = quest.experienceReward.ToString();
       goldText.text = quest.goldReward.ToString();
   }

   public void AcceptQuest()
   {
       questWindow.SetActive(false);
       questProgress.SetActive(true);
       quest.isActive = true;
       //give to player
       player.quest = quest;
       goal.DisplayProgress();
       
   }



}
