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
    private void Start()
    {
        // if new game{}
        money = startingMoney;
        moneyText.text = $"Wallet contains {money} gold";
    }




    public void UpdateText()
    {
        moneyText.text = $"Wallet contains {money} gold";
    }
}
