using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class BombItemMovement : MonoBehaviour
{
    [SerializeField] GameObject gamemanager;
    [SerializeField] GameManager gamemanagerscript;

    void Awake()
    {
        gamemanager = GameObject.Find("GameManager");
        gamemanagerscript = gamemanager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        { 
            Destroy(this.gameObject);
            gamemanagerscript.bombAdded();        
        }
    }
}
