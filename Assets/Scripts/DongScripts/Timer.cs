using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text minTime;
    public TMP_Text secTime;
    float time = 30; // 제한 시간 120초
    int min, sec;
    
    void Start()
    {
        //제한 시간 02:00
        minTime.text = "00";
        secTime.text = "30";

    }
    
        void Update()
    { 
        time -= Time.deltaTime;

        min = (int)time / 60;
        sec = ((int)time - min * 60) % 60;

        if (min <= 0 && sec <= 0)
        {
            minTime.text = 0.ToString();
            secTime.text = 0.ToString();

            
        }

        else {
            if (sec >= 60)
            {
                min += 1;
                sec -= 60;
            }
            else
            {
                minTime.text = min.ToString();
                secTime.text = sec.ToString();
            }
        }


   }
}
