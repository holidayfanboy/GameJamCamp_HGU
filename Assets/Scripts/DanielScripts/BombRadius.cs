using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombRadius : MonoBehaviour
{
    public GameObject bombradiusPrefab;

    void Awake()
    {
        StartCoroutine(InstantiateAfterDelay(1.4f)); 
    }

    IEnumerator InstantiateAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); 
        Instantiate(bombradiusPrefab, this.transform.position, Quaternion.Euler(0, 0, 0));
    }

    void Update()
    {
        
    }
}
