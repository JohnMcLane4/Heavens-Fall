using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private PlayerStats stats;

    //Start Init(); 
    void Start()
    {
        stats = PlayerStats.instance;

        stats.curHealth = stats.maxHealth;
    }

    public void DamagePlayer(int damage)
    {
        stats.curHealth -= damage;
        if (stats.curHealth <= 0)
        {
            GameMaster.KillPlayer(this);
        }
            
    }

}
