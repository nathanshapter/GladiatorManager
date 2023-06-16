using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyText;
    public int money;
    public int startingMoney;

    //method needs to be created to calculate the upgrade price of each skill, and the price of the slaves
    public int upgradePrice = 20; 
    private void Start()
    {
       
        money = startingMoney;
        moneyText.text = $"Wallet contains {money} gold";
    }

    public void UpdateText()
    {
        moneyText.text = $"Wallet contains {money} gold";
    }
}
