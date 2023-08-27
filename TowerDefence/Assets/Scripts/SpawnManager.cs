using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private Vector3 spawnPosition = new Vector3(1.7f, 0.6f, -0.2f);
    private float startDelay = 2f;
    private float repeatRate = 2f;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Enemy", startDelay, repeatRate);
    }

    void Enemy()
    {
        Debug.Log("EnemySpawned");
        Instantiate(enemy, spawnPosition, enemy.transform.rotation);
        //if (playerControllerScript.gameOver == false)
        //{
            
        //}
    }
}
