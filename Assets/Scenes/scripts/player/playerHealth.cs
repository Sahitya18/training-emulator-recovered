using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// when enemy attacks only for that purpose
public class playerHealth : MonoBehaviour
{
    int playerhealth;
    int headDamage, bodyDamage, legDamage;
    void Start()
    {
        playerhealth = 100;  
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.H))
            playerhealth -= headDamage;
        if (Input.GetKey(KeyCode.B))
            playerhealth -= bodyDamage;
        if (Input.GetKey(KeyCode.L))
            playerhealth -= legDamage;

        if (playerhealth <= 0) { 
            //-----------> game over ------>//
        }
    }
}
