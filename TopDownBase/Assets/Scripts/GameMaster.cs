using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    public static GameMaster gm;

    [SerializeField]
    private int maxLives = 3;    

    private static int _remainingLives = 1;
    public static int RemainingLives
    {
        get { return _remainingLives; }
    }

    [SerializeField]
    private int startingMoney;
    public static int Money;

    void Awake()
    {
        if (gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        }
    }

    private AudioManager audioManager;

    void Start()
    {
        _remainingLives = maxLives;

        Money = startingMoney;

        audioManager = AudioManager.instance;
        if (audioManager == null)
        {
            Debug.LogError("No AudioManager!");
        }
    }    

    public string spawnSoundName;
    public Transform playerPrefab;
    public Transform spawnPoint;
    public float spawnDelay = 4;
    public Transform explosionPrefab;
    //public Transform spawnEffectPrefab;    

    [SerializeField]
    private GameObject gameOverUI;    

    public void EndGame()
    {
        Debug.Log("GameOver");
        gameOverUI.SetActive(true);
    }

    public IEnumerator RespawnPlayer()
    {
        audioManager.PlaySound(spawnSoundName);
        yield return new WaitForSeconds(spawnDelay);

        Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        //Transform clone = (Transform)Instantiate(spawnEffectPrefab, spawnPoint.position, spawnPoint.rotation);
        //Destroy(clone.gameObject, 3f);
    }

	public static void KillPlayer(Player player)
    {
        Destroy(player.gameObject);
        _remainingLives -= 1;
        if(_remainingLives <= 0)
        {
            gm.EndGame();
        }
        else
        {
            gm.StartCoroutine(gm.RespawnPlayer());
        }        
        //Effect
    }

    public void KillEnemy(Enemy enemy)
    {
        ScoreCounter.scoreCount += 1;

        Money += enemy.moneyFromDeath;
        Destroy(enemy.gameObject);

        //add Effect
        Transform clone = (Transform)Instantiate(explosionPrefab, enemy.transform.position, enemy.transform.rotation);
        Destroy(clone.gameObject, 1.8f);
        //Music
        audioManager.PlaySound(enemy.enemyDeathSound);
    }
}
