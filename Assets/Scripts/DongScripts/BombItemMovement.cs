using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class BombItemMovement : MonoBehaviour
{
    public PlayerMovement player;

    public TMP_Text Bcounttext;
    public int bombCount;
    // Start is called before the first frame update
    void Start()
    {
        bombCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){ 
            Destroy(this.gameObject);
            bombCount++;
            Bcounttext.text = bombCount.ToString();
        }
    }
}
