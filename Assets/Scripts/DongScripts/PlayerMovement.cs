using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    [SerializeField] SpriteRenderer playerSpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        playerSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {   
         if (Input.GetKey(KeyCode.RightArrow))
        {
        
            playerSpriteRenderer.flipX = true;
            
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
        
            playerSpriteRenderer.flipX = false; 
            
        }
        float xMove=Input.GetAxis ("Horizontal")*speed*Time.deltaTime ; //x축으로 이동할 양
        float yMove=Input.GetAxis ("Vertical")*speed*Time.deltaTime; //y축으로 이동할양
        this.transform.Translate(new Vector3(xMove,yMove,0));  //이동

        //좌우반전 flip 사용하기 sprites renders
    }
}
