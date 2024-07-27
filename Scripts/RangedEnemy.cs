using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy : MonoBehaviour
{
    public float enemySpeed;
    private Transform target;
    public float stoppingDistance;

    public Transform FirePoint;
    public GameObject BulletPrefab;

    public float bulletForce = 20f;
    public float shootSpeed = 1.5f;
    public bool shootTimer;

    public GameObject deathEffect;
    public AudioSource Enemyhurt;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player1").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, enemySpeed * Time.deltaTime);
            shootTimer = true;
        }
        else
        {
            shootTimer = false;
        }


        if (shootTimer = true)
        {
            shootSpeed -= Time.deltaTime;
            if (shootSpeed <= 0)
            {
                Shoot();
                shootSpeed = 1.5f;
            }
        }
    }

    void Shoot()
    {
        GameObject Bullet = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.up * bulletForce, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Melee")
        {
            ScoreScript.scoreValue += 1;
            ScoreScript.rangedscoreValue += 1;
            GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(effect, 5f);
            Destroy(gameObject);
            Enemyhurt.Play();
        }
    }

}
