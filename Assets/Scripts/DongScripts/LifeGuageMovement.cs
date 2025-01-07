using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LifeGuageMovement : MonoBehaviour
{
    public Image gauge;
    public TMP_Text gaugeText;
    public PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {   
        SetGauge(0, 100, 100);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetGauge(int min, int max, int currentValue)
    {
        gauge.fillAmount = (currentValue - min) / (float)(max - min);
        gaugeText.text = currentValue.ToString();
    }
}
