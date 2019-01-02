using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Shop : MonoBehaviour {

    private PlayerStats stats;

    [SerializeField]
    private Text healthText;

    [SerializeField]
    private Text fireRateText;    

    void Start()
    {
        stats = PlayerStats.instance;

        StartCoroutine(UpdateShop());
    }
    
    IEnumerator UpdateShop()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            UpdateValues();
        }
    }

    void UpdateValues()
    {
        healthText.text = "Hull: " + stats.maxHealth.ToString("F1");
        fireRateText.text = "Firerate: " + stats.fireRate.ToString("F1");

    }

    public void PurchaseMoreHull()
    {
        if(GameMaster.Money < PlayerStats.instance.upgradeCostHull)
        {
            AudioManager.instance.PlaySound("NotEnoughMoney");
            return;
        }

        stats.maxHealth *= (int)(PlayerStats.instance.hullMultiplier);

        GameMaster.Money -= PlayerStats.instance.upgradeCostHull;
        AudioManager.instance.PlaySound("EnoughMoney");

        UpdateValues();
    }

    public void PurchasefireRateUpgrade()
    {
        if (GameMaster.Money < PlayerStats.instance.upgradeCostFireRate)
        {
            AudioManager.instance.PlaySound("NotEnoughMoney");
            return;
        }

        stats.fireRate *= PlayerStats.instance.fireRateMultiplier;

        GameMaster.Money -= PlayerStats.instance.upgradeCostFireRate;
        AudioManager.instance.PlaySound("EnoughMoney");

        UpdateValues();
    }

    public void PurchaseAdditionalLaser()
    {

    }

}
