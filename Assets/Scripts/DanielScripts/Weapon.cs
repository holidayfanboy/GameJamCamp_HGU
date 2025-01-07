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
    public AudioSource bulletClip;
    public AudioSource powerupClip;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {

        if (bigorsmall == 0)
        {
            bulletClip.Play();
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bulletscript = bullet.GetComponent<Bullet>();
            bulletscript.bteam = player.myteam;
            bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up  * fireForce, ForceMode2D.Impulse);
        }
        
        if (bigorsmall == 1)
        {
            bulletClip.Play();
            GameObject bigBullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        
            bigBullet.transform.localScale *= 10; 

            bulletscript = bigBullet.GetComponent<Bullet>();
            bulletscript.bteam = player.myteam;

            bigBullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        }
        
    }
    public void Now()
    {
        StartCoroutine(BigBullet());
    }

    IEnumerator BigBullet()
    { 
        powerupClip.Play();
        bigorsmall = 1;
        yield return new WaitForSeconds(3f); 
        bigorsmall = 0;
    }
}
