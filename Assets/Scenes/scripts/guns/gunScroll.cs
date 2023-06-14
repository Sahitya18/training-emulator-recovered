using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunScroll : MonoBehaviour
{
    public static gunScroll instance; // Variable intialized to access this script from other scripts
    public List<GameObject> gunPrefabs; // A list of GameObjects representing the different guns
    public float scrollSpeed = 5f; // The speed at which the scroll wheel moves the gun selection
    private int currentGunIndex = 0; // The index of the currently selected gun

    public GameObject currentGun; // Variable intialized for in hand weapon

    public bool gunScrolled; // Variable initialized to check whether the gun is changed or not----> used to close the ads or zoom of a gun when scrolled in between of a zoom
    private void Awake()
    {
        // To access this script from another script
        instance = this;
    }
    void Start()
    {
        // Instantiate the first gun in the list
        Instantiate(gunPrefabs[currentGunIndex], transform.position, transform.rotation, transform);
    }

    void Update()
    {
        scrollGun();
        inHandGun();
    }

    void scrollGun()
    {
        // Get the scroll wheel input
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");
        // After scrolling continuously getting update with false 
        gunScrolled = false;

        // If the scroll wheel has been moved, change the current gun
        if (scrollInput != 0)
        {
            // Increment or decrement the current gun index based on the scroll direction
            currentGunIndex += (scrollInput > 0) ? -1 : 1;

            // If we've reached the end of the list, stop there
            if (currentGunIndex >= gunPrefabs.Count)
            {
                currentGunIndex = 2;
            }
            // If we've reached the start of the list, stop there
            else if (currentGunIndex < 0)
            {
                currentGunIndex = 0;
            }

            // Destroy the current gun and instantiate the new one
            Destroy(transform.GetChild(0).gameObject);
            // Gun scrolled sett true when changed
            gunScrolled = true;
            // Spawn the new gun after scrolling         
            Instantiate(gunPrefabs[currentGunIndex], transform.position, transform.rotation, transform);
        }
    }

    public void inHandGun()
    {
        // In hand gun 
        currentGun = gunPrefabs[currentGunIndex];
        //print(currentGun);
    }
}