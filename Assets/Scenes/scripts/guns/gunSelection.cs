using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunSelection : MonoBehaviour
{
    public static int number;
    private void Start()
    {
        number = 0;
    }
    private void Update()
    {
        
    }
    public void chooseGun(int num)
    {
        number = num;
        //print("number1234: " + number);
        //gunScroll.number = num;
        //return number;
    }
}
