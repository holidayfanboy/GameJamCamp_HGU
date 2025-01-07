using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreGuageMovement : MonoBehaviour
{
    public ScoreManager sm;
    public Image gauge;
    public TMP_Text gaugeText;

    // Start is called before the first frame update
    void Start()
    {
        SetScoreGauge(0,0, 0);
    }

    // Update is called once per frame
    void Update()
    {   
        int totalnum = 0;
        for(int i=1;i<=4;i++){
            totalnum+=sm.scoreboard[i];
        }    

        if(this.gameObject.name == "ScoreGuage"){
            SetScoreGauge(0,totalnum, sm.scoreboard[2]);
        }else if(this.gameObject.name == "ScoreGuage1"){
            SetScoreGauge(0,totalnum, sm.scoreboard[1]);
        }else if(this.gameObject.name == "ScoreGuage2"){
            SetScoreGauge(0,totalnum, sm.scoreboard[3]);
        }else if(this.gameObject.name == "ScoreGuage3"){
            SetScoreGauge(0,totalnum, sm.scoreboard[4]);
        }
    }

    public void SetScoreGauge(int min, int max, int currentValue)
    {
        gauge.fillAmount = (currentValue - min) / (float)(max - min);
        gaugeText.text = currentValue.ToString();
    }
}
