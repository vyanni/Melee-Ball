using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : MonoBehaviour
{
    public float speed;
    public Joystick joystick;
    public Rigidbody2D rb;
    public GameObject deathEffect;


    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode2D.Impulse);
    }
}
