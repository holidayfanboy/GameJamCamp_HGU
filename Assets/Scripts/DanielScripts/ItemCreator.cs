using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreator : MonoBehaviour
{
    [SerializeField] GameObject bombitemPrefab;
    [SerializeField] GameObject lifeitemPrefab;
    [SerializeField] GameObject boostitemPrefab;

    private float randomx;
    private float randomy;
    private int item = 0;
    Vector3 targetPosition;
    void Awake()
    {
        RandomTarget();
        StartCoroutine(InstantiateAfterDelay(5f)); 
    }

    void Update()
    {
        Movement();
    }

    void RandomTarget()
    {
        randomx = Random.Range(-8,12);
        randomy = Random.Range(-18,3);
        item = Random.Range(1,4);
    }

    void Movement()
    {
    targetPosition = new Vector3(randomx, randomy, 0);
    }

    IEnumerator InstantiateAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); 
        if (item == 1)
        {
            Instantiate(bombitemPrefab, targetPosition, Quaternion.Euler(-90, 0, 0));
        } 
        else if (item == 2)
        {
            Instantiate(lifeitemPrefab, targetPosition, Quaternion.Euler(0, 0, 60));
        }
        else if (item == 3)
        {
            Instantiate(boostitemPrefab, targetPosition, Quaternion.Euler(0, 0, 0));
        }
        else
        {
            Debug.Log("Item not decided");
            Debug.Log("Item : " + item);
        }
        RandomTarget();
        StartCoroutine(InstantiateAfterDelay(5f)); 
    }
}
