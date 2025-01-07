using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundPaint : MonoBehaviour
{
    [SerializeField] int team = 0;
    [SerializeField] GameObject colormanager;
    [SerializeField] ColorManager colormanagerscript;
    private SpriteRenderer rend;

    void Awake()
    {
        colormanager = GameObject.Find("ColorManager");
        colormanagerscript = colormanager.GetComponent<ColorManager>();
        rend = GetComponent<SpriteRenderer>();
        rend.color = colormanagerscript.GiveColor(team);
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Bullet bulletScript = collision.gameObject.GetComponent<Bullet>();
            if (bulletScript != null)
            {
                team = bulletScript.bteam;
            }
            rend.color = colormanagerscript.GiveColor(team);
        }
    }
}
