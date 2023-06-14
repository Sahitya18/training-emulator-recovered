using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{

    Text time;
    void Start()
    {
        time = GetComponent<Text>();
        StartCoroutine(timers());
    }
    IEnumerator timers()
    {
        int seconds = 0;
        int minutes = 0;
        while (true)
        {
            yield return new WaitForSecondsRealtime(1f);
            seconds++;
            if (seconds > 60)
            {
                minutes++;
                seconds = 0;
            }

            if (seconds < 10)
            {
                if (minutes < 10)
                {
                    time.text = "0" + minutes + " : " + "0" + seconds;
                }
                else
                {
                    time.text = minutes + " : " + "0" + seconds;
                }
            }
            else
            {
                if (minutes < 10)
                {
                    time.text = "0" + minutes + " : " + seconds;
                }
                else
                {
                    time.text = minutes + " : " + seconds;
                }
                
            }
            //print("time " + minutes + " : " + seconds);
        }

    }
}
