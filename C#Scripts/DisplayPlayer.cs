using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayer : MonoBehaviour
{
    public Player player;
    public Text playerHealth;
    public Text playerExperience;
    public Text playerGold;

    void Start() {
        playerHealth.text = player.health.ToString();
        playerExperience.text = player.experience.ToString();
        playerGold.text = player.gold.ToString();
    }

    void Update()
    {
        playerHealth.text = player.health.ToString();
        playerExperience.text = player.experience.ToString();
        playerGold.text = player.gold.ToString();
    }
}
