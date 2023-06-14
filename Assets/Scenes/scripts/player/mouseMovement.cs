using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMovement : MonoBehaviour
{
    // [SerializeField]
    //Camera camera;

    //  Variable initialized for mouse sensitivity
    [SerializeField]
    int sensitivity;

    //  Variable initialized for player body
    [SerializeField]
    Transform playerBody;

    // Variable initialized for camera movement in y axis
    float yRotationVariable = 0f;

    // Variable initialized for Operator Gun zoom ( 2 times zoom counter)
    int count;

    // Crosshair gameobjects is initialized 
    [SerializeField]
    GameObject normalCrosshair, customCrosshair;
    private void Awake()
    {

        // Operator gun zoom counter set to 0
        count = 0;
        // To lock the cursor in the center of the screen
        Cursor.lockState = CursorLockMode.Locked;
        //setting initial camera angle to (0,0,0)
    }
    void Update()
    {
        // Calling mouse movement function 
        mousemover();
        // Calling zoom in function
        zoom();
    }
    private void mousemover()
    {
        // Getting movement of mouse in x axis and multiplying with sensitivity
        float mousex = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        // Rotating player body according to the mouse movement in x axis
        playerBody.Rotate(Vector3.up * mousex, Space.World);

        // Getting movement of mouse in y axis and multiplying with sensitivity
        float mousey = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Mouse movement is in opposite direction with respect to camera, so to make them in same direction  
        yRotationVariable -= mousey;

        // Clamping the camera for y axis with in -90 degree to 90 degree
        yRotationVariable = Mathf.Clamp(yRotationVariable, -90f, 90f);

        // Rotating camera according to the mouse movement in y axis
        transform.localEulerAngles = Vector3.right * yRotationVariable;
    }

    bool zoomed = false;
    GameObject currentWeapon;
    public void zoom()
    {
        // Getting current weapon as a gameobject from gun scroll script
        currentWeapon = gunScroll.instance.currentGun;

        // If gun scrolled default camera position is set used if gun scrolled in between a zoom
        if (gunScroll.instance.gunScrolled)
        {
            customCrosshair.SetActive(false);
            Camera.main.fieldOfView = 60;
            zoomed = false;
        }

        // Zoom setting for Operator gun
        if (currentWeapon.name == "Operator")
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                if (count == 0)
                {
                    customCrosshair.SetActive(true);
                    Camera.main.fieldOfView -= 20;
                    count++;
                }
                else if (count == 1)
                {
                    customCrosshair.SetActive(true);
                    Camera.main.fieldOfView -= 20;
                    count++;
                }
                else
                {
                    customCrosshair.SetActive(false);
                    Camera.main.fieldOfView = 60;
                    count = 0;
                }
            }
        }
        // Zoom setting for Marshal gun
        else if (currentWeapon.name == "Marshal" && Input.GetKeyDown(KeyCode.Mouse1) && !zoomed)
        {
            customCrosshair.SetActive(true);
            Camera.main.fieldOfView = 20;
            zoomed = true;
        }
        else if (currentWeapon.name == "Marshal" && Input.GetKeyDown(KeyCode.Mouse1) && zoomed)
        {
            customCrosshair.SetActive(false);
            Camera.main.fieldOfView = 60;
            zoomed = false;
        }
        // For remaining gun's ADS      
        if(Input.GetKeyDown(KeyCode.Mouse1)&&weaponDetails.instance.ads)
        {
            if(!zoomed)
            {
                Camera.main.fieldOfView = 40;
                zoomed = true;
            }
            else if(zoomed)
            {
                Camera.main.fieldOfView = 60;
                zoomed = false;
            }
        }
    }
}