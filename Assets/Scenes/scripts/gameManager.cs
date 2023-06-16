using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    int count=0;
    private void Start()
    {
        //count = 0;
    }
    private void Update()
    {
        print("count "+count);
        gunSelector();
    }
    void gunSelector()
    {
        if (Input.GetKey(KeyCode.B))
        {
            print("2222222222222");
            SceneManager.LoadScene(2);
            count++;
        }
        if (Input.GetKey(KeyCode.C))
        {
            print("hihihihihi");
            SceneManager.LoadScene(1);
            count++;
        }


    }
}
