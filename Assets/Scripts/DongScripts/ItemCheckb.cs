using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCheckb : MonoBehaviour
{
    public GameObject BombItem;
 
    public float countTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.childCount == 0){
            countTime+=Time.deltaTime;
        }
        
        if(countTime >= 10){
            BombItem = Instantiate(BombItem, this.transform.position, this.transform.rotation);
            BombItem.transform.parent = this.transform;
            countTime = 0;
        }
    }
}
