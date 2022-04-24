using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;
    public Player playerHealth; 
    protected NavMeshAgent enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Player") {
            playerHealth.health-=1;
            Debug.Log("Player Health is " + playerHealth.health);
        }
    }
}
