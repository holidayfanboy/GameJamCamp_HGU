using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMORotation : MonoBehaviour
{
    //[SerializeField] Rigidbody2D rb;
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
        Vector2 aimDirection = mousePosition - new Vector2 (transform.position.x, transform.position.y);
        float aimAngle = Mathf.Atan2(aimDirection.y,aimDirection.x) * Mathf.Rad2Deg - 180;
        transform.rotation = Quaternion.Euler(0, 0, aimAngle);
    }
}
