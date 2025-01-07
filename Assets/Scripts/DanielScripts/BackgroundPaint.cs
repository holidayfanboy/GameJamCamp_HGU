using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundPaint : MonoBehaviour
{
    [SerializeField] int team = 0;

    void Awake()
    {

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
                Debug.Log("Stage: " + team);
                Debug.Log("Bullet Triggered");
            }
        }
    }
}
