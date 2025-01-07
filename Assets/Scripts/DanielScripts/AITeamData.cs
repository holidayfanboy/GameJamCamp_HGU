using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITeamData : MonoBehaviour
{
    public int bteam;
    void Awake()
    {
        bteam = int.Parse(gameObject.name);
    }

    void Update()
    {
        
    }
}
