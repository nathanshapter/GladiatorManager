using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
   [SerializeField] Slave slave;
    Button button;
  [SerializeField]  TextMeshProUGUI buttonText;
    SelectSlaveMenu slaveMenu;
    [SerializeField] int slaveNumber = 0;
    MoneyManager moneyManager;
    [SerializeField] int numberToPass =1;
    private void Start()
    {
        slaveMenu= GetComponentInParent<SelectSlaveMenu>();
        button= GetComponent<Button>();
        
       
        buttonText= GetComponentInChildren<TextMeshProUGUI>();
        moneyManager = FindObjectOfType<MoneyManager>();
        UpdateButtonText(numberToPass);

       
    }

  public  void GetSlave()
    {
        if (slaveNumber >= slaveMenu.slaves.Length)
        {
            this.gameObject.SetActive(false);
            return;
        }
        else { this.gameObject.SetActive(true);}

        slave = slaveMenu.slaves[slaveNumber];
       
    }


     public void UpgradeSlaveAttribute(int attributeName) // if this is not working check to make sure the button is in the select slave menu
                                                            // implement method that puts them unavailable to fight for this week, and only one/two things can be upgraded at a time

      {
        switch(attributeName)
          {
              case 1: //strength
                  slave.character.strength += 1;
                  print(slave.character.name + " upgraded strength to " + slave.character.strength);
                slaveMenu.MySlavesMenu(false);
                break;
              case 2: // defence
                slave.character.defence += 1;
                  print(slave.character.name + " upgraded defence to " + slave.character.defence);
                slaveMenu.MySlavesMenu(false);
                break;
            case 3: // ;intelligence

                slave.character.intelligence += 1;
                print(slave.character.name + " upgraded intelligence to " + slave.character.intelligence);
                slaveMenu.MySlavesMenu(false);
                break;
            case 4: // charisma

                slave.character.charisma += 1;
                print(slave.character.name + " upgraded charisma to " + slave.character.charisma);
                slaveMenu.MySlavesMenu(false);
                break;
            case 5: // agility

                slave.character.agility += 1;
                print(slave.character.name + " upgraded agility to " + slave.character.agility);
                slaveMenu.MySlavesMenu(false);
                break;
            case 6: // endurance

                slave.character.endurance += 1;
                print(slave.character.name + " upgraded endurance to " + slave.character.endurance);
                slaveMenu.MySlavesMenu(false);
                break;
            case 7: // accuracy

                slave.character.accuracy += 1;
                print(slave.character.name + " upgraded accuracy to " + slave.character.accuracy);
                slaveMenu.MySlavesMenu(false);
                break;
            case 8: // resilience

                slave.character.resilience += 1;
                print(slave.character.name + " upgraded resilience to " + slave.character.resilience);
                slaveMenu.MySlavesMenu(false);
                break; 
            case 9: // leadership

                slave.character.leadership += 1;
                print(slave.character.name + " upgraded leadership to " + slave.character.leadership);
                slaveMenu.MySlavesMenu(false);
                break;
            case 10: // luck

                slave.character.luck += 1;
                print(slave.character.name + " upgraded luck to " + slave.character.luck);
                slaveMenu.MySlavesMenu(false);
                break;
            default:
                  print("Invalid attribute ID.");
                  break;
          }
      }

    public void UpdateButtonText(int attributeName)

    {
        switch (attributeName)
        {
            case 1: // strength
                buttonText.text = $"Strength(1) for {moneyManager.upgradePrice}"; // turn this into a method to get price
                break;
            case 2: // Defense
                
                buttonText.text = $"Defence (1) for {moneyManager.upgradePrice}"; // turn this into a method to get price
                break;
            case 3: // ;intelligence

                buttonText.text = $"Intelligence (1) for {moneyManager.upgradePrice}"; // turn this into a method to get price
                break;
            case 4: // charisma

                buttonText.text = $"Charisma (1) for {moneyManager.upgradePrice}"; // turn this into a method to get price
                break;
            case 5: // agility

                buttonText.text = $"Agility (1) for {moneyManager.upgradePrice}"; // turn this into a method to get price
                break;
            case 6: // endurance

                buttonText.text = $"Endurance (1) for {moneyManager.upgradePrice}"; // turn this into a method to get price
                break;
            case 7: // accuracy

                buttonText.text = $"Accuracy (1) for {moneyManager.upgradePrice}"; // turn this into a method to get price
                break;
            case 8: // resilience

                buttonText.text = $"Resilience (1) for {moneyManager.upgradePrice}"; // turn this into a method to get price
                break;
            case 9: // leadership

                buttonText.text = $"Leadership (1) for {moneyManager.upgradePrice}"; // turn this into a method to get price
                break;
            case 10: // luck

                buttonText.text = $"Luck (1) for {moneyManager.upgradePrice}"; // turn this into a method to get price
                break;
            default:
                print("Invalid attribute ID.");
                break;
        }

    }



}
