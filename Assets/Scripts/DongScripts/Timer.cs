using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public TMP_Text minTime;
    public TMP_Text secTime;
    public ScoreManager scoreManager;
    public GameObject EndUI;
    public TMP_Text resultwinner; // 게임 종료시 이긴 팀
    public TMP_Text resultscore; 
    float time = 30; // 제한 시간 120초
    int min, sec;
    
    int max = 0;
    int result = 0;
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
            scoreManager.PlaySound();

            minTime.text = 0.ToString();
            secTime.text = 0.ToString();
            
            for(int i=1;i<=4;i++){
            
                if(scoreManager.scoreboard[i]>=max){
                    max = scoreManager.scoreboard[i];
                    result = i;
                }
            } 
            Time.timeScale = 0;
            if(result == 1){
                resultwinner.text = "winner team: Red team";
                resultscore.text = max.ToString();
            }else if(result == 2){
                resultwinner.text = "winner team: Blue team";
                resultscore.text = max.ToString();
            }else if(result == 3){
                resultwinner.text = "winner team: Green team";
                resultscore.text = max.ToString();
            }else if(result == 4){
                resultwinner.text = "winner team: Yellow team";
                resultscore.text = max.ToString();
            }
            EndUI.SetActive(true);
        }
        else {
            Time.timeScale = 1;
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
    

