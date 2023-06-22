using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public bool gamePause;
    public GameObject selfCanvas;
    int count=0;
    private void Start()
    {
        gamePause = false;
        //count = 0;
    }
    private void Update()
    {
        gunSelector();
    }
     void gunSelector()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (count % 2 == 0)
            { 
                selfCanvas.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                gamePause = true;
                count++; 
            }
            else if (count % 2 != 0)
            {
                selfCanvas.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                gamePause = false;
                count++;
            }
        }


    }
}
