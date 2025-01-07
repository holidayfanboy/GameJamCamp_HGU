using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] int[] scoreboard = new int[]
    {
        0,
        0,
        0,
        0,
        0,
        0
    };
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreRecord(int prevteam, int curteam)
    {
        if (prevteam == 0)
        {
            scoreboard[curteam] = scoreboard[curteam] + 1;
        }
        else
        {
            scoreboard[prevteam] = scoreboard[prevteam] - 1;
            scoreboard[curteam] = scoreboard[curteam] + 1;
        }
    }
}
