using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    [SerializeField] float randomx;
    [SerializeField] float randomy;
    private float moveSpeed = 2.5f;
    void Awake()
    {
        RandomTarget();
    }

    void Update()
    {
        Movement();
    }

    void RandomTarget()
    {
        randomx = Random.Range(-10,14);
        randomy = Random.Range(-20,5);
    }

    void Movement()
{
    Vector3 targetPosition = new Vector3(randomx, randomy, 0);
    transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

    if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
    {
        RandomTarget(); 
    }
}

}
