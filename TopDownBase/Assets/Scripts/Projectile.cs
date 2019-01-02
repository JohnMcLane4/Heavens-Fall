using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed;
    public float damage = 40f;
    public Rigidbody rb;
    //public Layermask notToHit;  //Cloud use that to layer everything we dont want to hit

    //public GameObject hitEffect;
    public GameObject hitEnemy;


    void Start ()
    {
        rb = GetComponent<Rigidbody>();

        rb.velocity = transform.forward * speed;

        hitEnemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    void OnTriggerEnter(Collider hit)
    {
        if(hit.tag == "Boundary")
        {
            return;
        }

        Enemy enemy = hit.GetComponent<Enemy>();
        
        if(hitEnemy != null)
        {
            enemy.DamageEnemy(damage * PlayerStats.instance.damageMultiplier);
        }

        //Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
