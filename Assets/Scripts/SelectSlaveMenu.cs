using System;
using System.Collections;
using System.Collections.Generic;
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
    int activeMenu = 0;
    string slaveText = "";
    int firstNumber =0 , secondNumber =1, thirdNumber =2;

    private void Start()
    {
        DisableAllSlaveSelection();
        EnableSlave(activeMenu);
        mySlaves.gameObject.SetActive(false);
        
    }

    public void PreviousSlave()
    {
        DisableAllSlaveSelection();
        if(activeMenu ==0)
        {
            activeMenu = slaveSelection.Length -1;

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
        slaveText= null;
    }
    private void DisableAllUISlaveMenu()
    {
        DisableAllSlaveSelection();
        foreach (var item in slaveSelectionMenuUI)
        {
            item.gameObject.SetActive(false);
        }
    }
    private void EnableSlave(int i)
    {
       
        slaveSelection[i].gameObject.SetActive(true);
        foreach (var item in slaveSelectionMenuUI)
        {
            item.gameObject.SetActive(true);
        }
    }
    public void MySlavesMenu()
    {
        DisableAllUISlaveMenu();

        mySlaves.gameObject.SetActive(true);
        Slave[] slaves = FindObjectsOfType<Slave>();

        int number = 0;
        int numberInfo = 0;

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
        foreach (var item in mySlaveText)
        {
          if(number >= slaves.Length) { break; }
               
                item.text = slaves[number].character.name;
                number++;
            
           
        }

        foreach (var item in mySlaveTextInfo)
        {
            if (numberInfo >= slaves.Length) { break; }
            //  item.text = $"change this to info string + {slaves[numberInfo].character.name}";
            item.text =    $"This slaves stats are Strength: {slaves[numberInfo].character.strength}, Defence: {slaves[numberInfo].character.defence}, Intelligence: {slaves[numberInfo].character.intelligence}," +
            $"Charisma: {slaves[numberInfo].character.charisma}, Agility: {slaves[numberInfo].character.agility}, Endurance: {slaves[numberInfo].character.endurance}, Accuracy: {slaves[numberInfo].character.accuracy}," +
            $"Resilience: {slaves[numberInfo].character.resilience}, Leadership: {slaves[numberInfo].character.leadership}, Luck: {slaves[numberInfo].character.luck} " +
            $"There Max stat is {slaves[numberInfo].character.maxStat}, and minimum stat is {slaves[numberInfo].character.minStat}";
            numberInfo++;
        }
        Array.Reverse(slaves);

        SlaveTextOn(firstNumber, secondNumber, thirdNumber);
    }
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
