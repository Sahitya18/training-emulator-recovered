using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class missed : MonoBehaviour
{
    Text missedScore;
    public static int scoreValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        missedScore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        missedScore.text = "" + scoreValue;
    }


}
