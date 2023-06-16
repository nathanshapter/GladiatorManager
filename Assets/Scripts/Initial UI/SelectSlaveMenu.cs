using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class SelectSlaveMenu : MonoBehaviour
{
    [SerializeField] GameObject[] slaveSelection;
    [SerializeField] GameObject[] slaveSelectionMenuUI;
    [SerializeField] GameObject mySlaves;
    [SerializeField] TextMeshProUGUI[] mySlaveText, mySlaveTextInfo;
    [SerializeField] GameObject nextSlaves, previousSlaves;
    [SerializeField] UpgradeButton[] upgradeButton;
    [SerializeField] GameObject[] auctionMenu;
    [SerializeField] GameObject battleMenuButton;
    [SerializeField] GameObject slaveAuctionButton;
    [SerializeField] SelectYourSlaves selectYourSlavesForBattle;
    [SerializeField] GameObject battleMenuUI;
    [SerializeField] SlaveBattleMenu slaveBattleMenu;
    int activeMenu = 0;
    string slaveText = "";
    int firstNumber =0 , secondNumber =1, thirdNumber =2;
    public Slave[] slaves;


    /// <summary>
    /// the purpose of this script is to turn on and off all UI that is a part of the main menu battle menu, and slave auction
    /// </summary>
 
    private void Start()
    {
        DisableEverything(false);
        EnableSlave(activeMenu);
        mySlaves.gameObject.SetActive(false);
     
        
    }
    public void FindSlaves()
    {
        slaves = FindObjectsOfType<Slave>();

    }
    // extras is provided as a bool as sometimes i dont want to disable everything everything
    public   void DisableEverything(bool extras)
    {
        foreach (var item in slaveSelection)
        {
           item.gameObject.SetActive(false);
        }
        slaveText = null;
        foreach (var item in slaveSelectionMenuUI)
        {
            item.gameObject.SetActive(false);
        }
        mySlaves.gameObject.SetActive(false);
        foreach (var item in auctionMenu)
        {
            item.SetActive(false);
        }
      battleMenuUI.gameObject.SetActive(false);
        selectYourSlavesForBattle.gameObject.SetActive(false);
        if (extras)
        {
            slaveAuctionButton.SetActive(false);
            slaveBattleMenu.gameObject.SetActive(false);
            battleMenuButton.SetActive(false);
        }
                 
    }



    // the bool is set to false when you just want to update the text, else a full reload is marked for true
    //this method populates the information about the slaves, their price, the button when purchased, and their stats
    public void MySlavesMenu(bool yes) 
    {
        int number = 0;
        int numberInfo = 0;
        if (yes)
        {
            FindSlaves();
            DisableEverything(false);



            mySlaves.gameObject.SetActive(true);
            battleMenuButton.gameObject.SetActive(true);

           

            if (slaves.Length > 3)
            {
                nextSlaves.gameObject.SetActive(true);
                previousSlaves.gameObject.SetActive(true);
            }
            else
            {
                nextSlaves.gameObject.SetActive(false);
                previousSlaves.gameObject.SetActive(false);
            }
            Array.Reverse(slaves);

            foreach (var item in upgradeButton)
            {
               
                item.GetSlave();
            }


            foreach (var item in mySlaveText)
            {
                if (number >= slaves.Length) { break; }

                item.text = slaves[number].character.name;
                number++;


            }

            foreach (var item in mySlaveTextInfo)
            {
                if (numberInfo >= slaves.Length) { break; }
                //  item.text = $"change this to info string + {slaves[numberInfo].character.name}";
                item.text = $"This slaves stats are Strength: {slaves[numberInfo].character.strength},\nDefence: {slaves[numberInfo].character.defence},\nIntelligence: {slaves[numberInfo].character.intelligence},\n" +
                $"Charisma: {slaves[numberInfo].character.charisma},\nAgility: {slaves[numberInfo].character.agility},\nEndurance: {slaves[numberInfo].character.endurance},\nAccuracy: {slaves[numberInfo].character.accuracy},\n" +
                $"Resilience: {slaves[numberInfo].character.resilience},\nLeadership: {slaves[numberInfo].character.leadership},\nLuck: {slaves[numberInfo].character.luck},\n" 
                ;
                numberInfo++;
            }
            Array.Reverse(slaves);

            SlaveTextOn(firstNumber, secondNumber, thirdNumber);
        }
        else
        {
            Array.Reverse(slaves);
            foreach (var item in mySlaveTextInfo)
            {
                if (numberInfo >= slaves.Length) { break; }
                //  item.text = $"change this to info string + {slaves[numberInfo].character.name}";
                item.text = $"This slaves stats are Strength: {slaves[numberInfo].character.strength},\nDefence: {slaves[numberInfo].character.defence},\nIntelligence: {slaves[numberInfo].character.intelligence},\n" +
                $"Charisma: {slaves[numberInfo].character.charisma},\nAgility: {slaves[numberInfo].character.agility},\nEndurance: {slaves[numberInfo].character.endurance},\nAccuracy: {slaves[numberInfo].character.accuracy},\n" +
                $"Resilience: {slaves[numberInfo].character.resilience},\nLeadership: {slaves[numberInfo].character.leadership},\nLuck: {slaves[numberInfo].character.luck},\n" 
                ;
                numberInfo++;
            }
            Array.Reverse(slaves);
        }
       
    }


    // these four methods are for navigating the slave auction menu
    public void PreviousSlave()
    {
        DisableEverything(false);
        if (activeMenu == 0)
        {
            activeMenu = slaveSelection.Length - 1;

        }
        else
        {
            activeMenu--;
        }
        EnableSlave(activeMenu);
    }
    public void NextSlave()
    {
        DisableAllSlaveSelection();
        if (activeMenu == slaveSelection.Length - 1)
        {
            activeMenu = 0;

        }
        else
        {
            activeMenu++;
        }
        EnableSlave(activeMenu);
    }

    private void DisableAllSlaveSelection()
    {
        foreach (var item in slaveSelection)
        {
            item.gameObject.SetActive(false);
        }
        slaveText = null;
    }

    private void EnableSlave(int i)
    {

        slaveSelection[i].gameObject.SetActive(true);
        foreach (var item in slaveSelectionMenuUI)
        {
            item.gameObject.SetActive(true);
        }
    }


    // these four methods are for navigating the myslaves menu

    void SlaveTextOn(int one, int two, int three)
    {
        foreach (var item in mySlaveText)
        {
            item.gameObject.SetActive(false);
        }
        mySlaveText[one].gameObject.SetActive(true);
        mySlaveText[two].gameObject.SetActive(true);
        mySlaveText[three].gameObject.SetActive(true);
    }
    public void DisableMySlavesMenu()
    {
        DisableEverything(false);
        mySlaves.gameObject.SetActive(false);
        EnableSlave(activeMenu);
    }

    public void NextSlavePage()
    {

        firstNumber += 3;
        secondNumber += 3;
        thirdNumber += 3;
        SlaveTextOn(firstNumber, secondNumber, thirdNumber);
    }
    public void PreviousSlavePage() 
    {
        firstNumber -= 3;
        secondNumber -= 3;
        thirdNumber -= 3;
        SlaveTextOn(firstNumber, secondNumber, thirdNumber);
    }
  
}
