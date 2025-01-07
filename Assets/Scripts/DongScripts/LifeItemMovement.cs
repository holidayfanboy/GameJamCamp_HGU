using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotSpeed = 100f;
    public PlayerMovement player;

    public LifeGuageMovement lguage;

    public GameObject lifeItem;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   

        transform.Rotate(new Vector3(0,0,rotSpeed *Time.deltaTime)); //Time.deltaTime을 곱하는 이유는 모든 컴퓨터에서 똑같이 움직이게 하기 위해서이다.

    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player" && player.life != 100){ 
            player.life += 5;
            lguage.SetGauge(0,100,player.life);
            Destroy(this.gameObject);
        }
    }
}