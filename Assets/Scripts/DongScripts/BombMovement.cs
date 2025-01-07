using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMovement : MonoBehaviour
{   
    public int bteam = 2;
    void Awake()
    {
        StartCoroutine(SelfDestroy(0.5f)); 
    }

    IEnumerator SelfDestroy(float delay)
    {
        yield return new WaitForSeconds(delay); 
        Destroy(this.gameObject);
    }
}
