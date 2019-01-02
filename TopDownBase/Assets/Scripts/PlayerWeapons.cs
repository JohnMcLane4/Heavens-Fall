using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapons : MonoBehaviour {

    public Transform firepoint;    
    float timeToFire = 1;
    public GameObject bulletPrefab;

    public string shootSound = "DefaultShot";

    AudioManager audioManager;

    // Use this for initialization
    void Start ()
    {
        audioManager = AudioManager.instance;
        if (audioManager == null)
        {
            Debug.LogError("No AudioManager!");
        }
    }

    void Update()
    {
        if (PlayerStats.instance.fireRate == 0)
        {
            if (Input.GetButton("Fire1"))
            {
                Shoot();
            }
        }
        else
        {            
            if (Input.GetButton("Fire1") && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / PlayerStats.instance.fireRate;
                Shoot();
            }
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        audioManager.PlaySound(shootSound);
    }
}
