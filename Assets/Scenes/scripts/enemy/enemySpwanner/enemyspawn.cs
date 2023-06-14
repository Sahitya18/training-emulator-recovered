using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
    public static enemyspawn instance; // Variable intialized to access this script from other scripts

    // GameObjects
    [SerializeField]
    GameObject[] spawnPositions;   // Spawning positions (Arrays)
    [SerializeField]
    GameObject enemy;              // Getting prefab
    GameObject spawnedObject;      // Variable for Spawned enemies
    // Integer
    int enemyKillCounter = 0;
    // Boolean
    public bool enemyIsAlive;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        startspawning();
    }
    public void enemySpawner()
    {
        // Getting random position for spawning
        int randomPosition = Random.Range(0, spawnPositions.Length);

        // Spawning enemies
        spawnedObject= Instantiate(enemy, spawnPositions[randomPosition].transform.position, transform.rotation);
        // Everytime a new enemy spawn with boolean true indicates alive or not
        enemyIsAlive = true;
        // Accessing enemyLivingState function from damage taking script to change the boolean of state of living(Alive or dead)
        enemy.GetComponent<damageTaking>().enemyLivingState();
    }
    IEnumerator enemySpawnDelay()
    {
        // this will b deleted after checking all the bugs 
        int birth = 0, b1 = 0,notdead=0, count=0;
        // 1 Second hault
        yield return new WaitForSecondsRealtime(1f);
        while (count++<30)
        {
            enemySpawner();
            birth++;
            b1++;
            // print("enemy birth state " + birth + " " + enemyIsAlive);
            // time taken by player to hit the target
            yield return new WaitForSecondsRealtime(1f);

            // Getting the boolean from damage taking script that enemy is alive or not
            enemyIsAlive = enemy.GetComponent<damageTaking>().enemyIsAlive;
            //print("enemy is alive "+b1+" " + enemyIsAlive);
            // if enemy is not alive it will increase the enemyKillCounter counter and destroy the object
            if (!enemyIsAlive)
            {
                //print("spawned object "+spawnedObject);
                Destroy(spawnedObject);
                //print("killed");
                enemyKillCounter++;
                score.scoreValue = enemyKillCounter;
                print("count enemy "+enemyKillCounter);
 
            }
            // if enemy is alive it will increase the notdead counter and detroy the object
            else if (enemyIsAlive)
            {
                Destroy(spawnedObject);
                //print("not killed");
                notdead++;
                missed.scoreValue = notdead;
                print("nd " + notdead);
                
            }
            // hault for 2 Second to respawn
            yield return new WaitForSecondsRealtime(2f);
        }
    }
    public void startspawning()
    {
        StartCoroutine(enemySpawnDelay());
    }
}

//Remarks: Remove print statements