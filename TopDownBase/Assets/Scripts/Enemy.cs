using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [System.Serializable]
    public class EnemyStats
    {
        public float maxHealth = 100;
        public int Speed = 10;
        public int collisionDamage = 50;

        private float _curHealth;
        public float curHealth
        {
            get { return _curHealth; }
            set { _curHealth = Mathf.Clamp(value, 0, maxHealth); }  //if setting curHealth, it stays between 0 and maxHealth
        }

        //initilisation of health amount
        public void Init()
        {
            curHealth = maxHealth;
        }
    }

    public string enemyDeathSound = "Explosion";

    public EnemyStats enemyStats = new EnemyStats();
   
    public Rigidbody rb;

    public static GameMaster gm;

    public int moneyFromDeath = 10;

    //public GameObject deathEffect;    

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.velocity = transform.forward * -enemyStats.Speed;

        //gm = FindComponent<GameMaster>();
        gm = FindObjectOfType<GameMaster>();
    }    

    public void DamageEnemy(float damage)
    {
        
        enemyStats.curHealth -= damage;
        if (enemyStats.curHealth <= 0)
        {
            gm.KillEnemy(this);
        }
    }
    
    /*void OnCollisionEnter(Collision collision)
    {
        Player _player = collision.collider.GetComponentInParent<Player>();
        if(_player != null)
        {            
            _player.DamagePlayer(enemyStats.collisionDamage);
            DamageEnemy(9999999);
            //GameMaster.KillEnemy(enemy.gameObject);
        }
        else
        {
            Debug.Log("No Detection!");
        }
    }*/

    void OnTriggerEnter(Collider hit)
    {
        Player _player = hit.GetComponentInParent<Player>();
        if (_player != null)
        {
            _player.DamagePlayer(enemyStats.collisionDamage);
            DamageEnemy(9999999);
            //GameMaster.KillEnemy(this);
        }
    }
}
