using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private SpriteRenderer playerSpriteRenderer;
    public int life;
    private Rigidbody2D rigid2D;
    public LifeGuageMovement lguage;
    public TMP_Text Bcounttext;
    public BombItemMovement BombItem;

    [SerializeField] private GameObject Bomb;
    public GameObject GmBomb;

    // Start is called before the first frame update
    void Start()
    {
        life = 100;
        speed = 5;
        playerSpriteRenderer = GetComponent<SpriteRenderer>();
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
         if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
        
            playerSpriteRenderer.flipX = true;
            
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
        
            playerSpriteRenderer.flipX = false; 
            
        }
        float xMove=Input.GetAxis ("Horizontal")*speed*Time.deltaTime ; //x축으로 이동할 양
        float yMove=Input.GetAxis ("Vertical")*speed*Time.deltaTime; //y축으로 이동할양
        this.transform.Translate(new Vector3(xMove,yMove,0));  //이동

        if(Input.GetKey(KeyCode.Alpha3) && BombItem.bombCount > 0){
            FireBomb(); 
            BombItem.bombCount -= 1;
            Bcounttext.text = BombItem.bombCount.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.name == "wall"){ //wall를 만나면 게이지 깍이기기
            life -= 5;
            lguage.SetGauge(0,100,life);
        }
    }

    public void FireBomb(){
        GmBomb = (GameObject)Instantiate(Bomb, this.transform.position, this.transform.rotation) as GameObject;
        Destroy(GmBomb, 3.0f);   
    }
}
