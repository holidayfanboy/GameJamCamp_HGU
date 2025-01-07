using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCheck1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LifeItem;
    void Start()
    {
        
    }

    float countTime;
    // Update is called once per frame
    void Update()
    {
        Transform childTransform = transform.Find("LifeItem");
        if(childTransform == null){
            countTime+=1;
        }

        if(countTime == 10){
            LifeItem = (GameObject)Instantiate(LifeItem, this.transform.position, this.transform.rotation) as GameObject;
        }
    }
}
