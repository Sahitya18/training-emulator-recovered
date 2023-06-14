using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageTaking : MonoBehaviour
{
    public static damageTaking instance; // Variable intialized to access this script from other scripts

    public int enemyHealth; // Health of enemy

    public bool enemyIsAlive; // Living state of enemy
    
   
    void Awake()
    {
        // Initial default values
        enemyIsAlive = true;
        enemyHealth = 150;
    }
    private void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        print("enemy healthqq "+enemyHealth);
        //print("time "+Time.realtimeSinceStartup);
    }

    // Getting damage from gunSystem script
    public void gettingDamage(int damage)
    {
        // Enemy health changing according to the weapon damage from the script gun System
        enemyHealth -= damage;
        if (enemyHealth <= 0)
        {
            enemyIsAlive = false;
        }
    }

    // Only to change the enemyIsAlive to true
    public void enemyLivingState()
    {
        enemyIsAlive = true;
        enemyHealth = 150;
    }

}

//Remarks: Remove print statements