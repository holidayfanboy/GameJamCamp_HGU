using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCheck1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LifeItem;
    //public GameObject LifeItemEm;
    public float countTime;
    GameObject prefabl;
    
    void start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        //Transform childTransform = transform.Find("LifeItem");
        if(this.transform.childCount == 0){
            countTime+=Time.deltaTime;
        }
        
        if(countTime >= 10){
            prefabl = Resources.Load<GameObject>("Prefabs/LifeItem");;
            LifeItem = Instantiate(prefabl, this.transform.position, this.transform.rotation);
            LifeItem.transform.SetParent(this.transform);
            countTime = 0;
        }
    }
}
