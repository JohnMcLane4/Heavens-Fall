using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class MoneyCounter : MonoBehaviour
{

    private Text moneyCounterText;


    
    void Awake()
    {
        moneyCounterText = GetComponent<Text>();
    }

   
    void Update()
    {
        moneyCounterText.text = "MONEY: " + GameMaster.Money.ToString();
    }
}
