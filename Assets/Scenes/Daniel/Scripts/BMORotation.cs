using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMORotation : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Weapon weapon;

    Vector2 mousePosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            weapon.Fire();
        }

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y,aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }
}
