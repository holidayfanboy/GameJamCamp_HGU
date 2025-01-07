using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundPaint : MonoBehaviour
{
    public int team = 0;
    [SerializeField] GameObject colormanager;
    [SerializeField] ColorManager colormanagerscript;
    [SerializeField] GameObject scoremanager;
    [SerializeField] ScoreManager scoremanagerscript;
    private SpriteRenderer rend;

    void Awake()
    {
        colormanager = GameObject.Find("ColorManager");
        colormanagerscript = colormanager.GetComponent<ColorManager>();
        scoremanager = GameObject.Find("ScoreManager");
        scoremanagerscript = scoremanager.GetComponent<ScoreManager>();
        rend = GetComponent<SpriteRenderer>();
        rend.color = colormanagerscript.GiveColor(team);
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        int newteam = 0;
        if (collision.gameObject.tag == "Bullet")
        {
            Bullet bulletScript = collision.gameObject.GetComponent<Bullet>();
            if (bulletScript != null)
            {
                newteam = bulletScript.bteam;
            }
            rend.color = colormanagerscript.GiveColor(newteam);
            scoremanagerscript.ScoreRecord(team, newteam);
            team = newteam;
        }

        if (collision.gameObject.tag == "Enemy")
        {
            //Debug.Log("Enemy triggered");
            AITeamData aiScript = collision.gameObject.GetComponent<AITeamData>();
            if (aiScript != null)
            {
                newteam = aiScript.bteam;
                //Debug.Log("newteam: " + newteam);
            }
            rend.color = colormanagerscript.GiveColor(newteam);
            scoremanagerscript.ScoreRecord(team, newteam);
            team = newteam;
        }

        if(collision.gameObject.tag == "Bomb"){
            BombMovement bombScript = collision.gameObject.GetComponent<BombMovement>();
            if (bombScript != null)
            {
                newteam = bombScript.bteam;
            }
            rend.color = colormanagerscript.GiveColor(newteam);
            scoremanagerscript.ScoreRecord(team, newteam);
            team = newteam;
        }
    }
}

