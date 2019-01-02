using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;

    public int maxHealth = 100;

    public float movementSpeed = 20f;
    public float fireRate = 3f;
    public float damageMultiplier = 1.0f;

    //Variables for Shop
    public float hullMultiplier = 1.2f;
    public float fireRateMultiplier = 1.2f;
    public int upgradeCostFireRate = 50;
    public int upgradeCostHull = 50;



    private int _curHealth;
    public int curHealth
    {
        get { return _curHealth; }
        set { _curHealth = Mathf.Clamp(value, 0, maxHealth); }  //if setting curHealth, clamp it between 0 and maxHealth
    }

    //initilisation of health amount
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        curHealth = maxHealth;
    }
}
    
