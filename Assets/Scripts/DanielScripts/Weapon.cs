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
    public int bigorsmall = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        Debug.Log(bigorsmall);
        
        if (bigorsmall == 0)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bulletscript = bullet.GetComponent<Bullet>();
            bulletscript.bteam = player.myteam;
            bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up  * fireForce, ForceMode2D.Impulse);
        }
        
        if (bigorsmall == 1)
        {
            GameObject bigBullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        
            bigBullet.transform.localScale *= 2; 

            bulletscript = bigBullet.GetComponent<Bullet>();
            bulletscript.bteam = player.myteam;

            bigBullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        }
        
    }

    IEnumerator BigBullet()
    { 
        bigorsmall = 1;
        yield return new WaitForSeconds(5f); 
        bigorsmall = 0;
    }
}
