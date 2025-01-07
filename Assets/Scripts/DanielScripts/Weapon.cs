using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Bullet bulletscript;
    [SerializeField] Transform firePoint;
    [SerializeField] PlayerMovement player;
    private float fireForce = 8f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bulletscript = bullet.GetComponent<Bullet>();
        bulletscript.bteam = player.myteam;
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up  * fireForce, ForceMode2D.Impulse);
        
    }
}
