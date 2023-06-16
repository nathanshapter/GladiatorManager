using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SlaveSelectionButton : MonoBehaviour
{
 
    [SerializeField] TextMeshProUGUI buttonText, infoText;

    public Character character;
    public Character currentCharacter;
    MoneyManager money;
    SlaveManager sm;
    bool purchased;

    private void Start()
    {
     
        sm = FindObjectOfType<SlaveManager>();
        money = FindObjectOfType<MoneyManager>();
        buttonText.text = character.slaveName + $" The price is {character.slavePrice}";
        infoText.text = $"This slaves stats are Strength: {character.strength}, Defence: {character.defence}, Intelligence: {character.intelligence}," +
            $"Charisma: {character.charisma}, Agility: {character.agility}, Endurance: {character.endurance}, Accuracy: {character.accuracy}," +
            $"Resilience: {character.resilience}, Leadership: {character.leadership}, Luck: {character.luck} " 
            ;

       
   //   Instantiate(character.replacementSlavePrefab);
        
    }
   
    public void BuySlave()
    {
        if(money.money >= character.slavePrice && !purchased)
        {
            sm.chosenCharacter = character;
            money.money -= character.slavePrice;
            
            money.UpdateText();
            print($"You have purchased {character.slaveName} for {character.slavePrice}");
            // add this slave to your slavemanager
            sm.newSlave(character);
            purchased = true;
            buttonText.text = "You own this slave";
        }
        else if(money.money >= character.slavePrice)
        {
            print("You have already purchased this character");
        }
        else
        {
            print("You do not have enough money");
        }
        // open next menu for battle management
    }
    
}
