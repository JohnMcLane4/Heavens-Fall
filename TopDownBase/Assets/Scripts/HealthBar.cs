using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    
    private float fillAmount;

    [SerializeField]
    private Image healthPerc;

    [SerializeField]
    private Text healthText;

    private PlayerStats stats;

    private float percent;
	
	void Start ()
    {
        stats = PlayerStats.instance;

        UpdateHealthBar();        
    }

    void Update()
    {
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {

        percent = stats.curHealth / stats.maxHealth;

        //float percent = stats.curHealth / stats.maxHealth;
        //healthPerc.rectTransform.localScale = new Vector3(percent, 1, 1); //Vector3(x,y,z)
        healthPerc.fillAmount = percent;
        healthText.text = (percent * 100).ToString("0");
    }       
}
