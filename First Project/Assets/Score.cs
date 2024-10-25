using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    string score = "Car Score:";
    public int scoreval = 0;
    //AddScore increments the value of score by 1.
    public void AddScore()
    {
        scoreval++;
        print(score + scoreval);
    }
}
