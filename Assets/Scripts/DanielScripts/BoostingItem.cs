using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostingItem : MonoBehaviour
{
    [SerializeField] GameObject weapon;
    [SerializeField] Weapon weaponscript;

    void Awake()
    {
        weapon = GameObject.Find("Weapon");
        weaponscript = weapon.GetComponent<Weapon>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){ 
            weaponscript.Now();
            Destroy(this.gameObject);
        }
    }
}
