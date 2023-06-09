using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SelectSlaveMenu : MonoBehaviour
{
    [SerializeField] GameObject[] slaveSelection;
    [SerializeField] GameObject[] slaveSelectionMenuUI;
    [SerializeField] GameObject mySlaves;
    [SerializeField] TextMeshProUGUI[] mySlaveText;
    [SerializeField] GameObject nextSlaves, previousSlaves;
    int activeMenu = 0;
    string slaveText = "";

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
        Array.Reverse(slaves);


    }
    public void DisableMySlavesMenu()
    {
        mySlaves.gameObject.SetActive(false);
        EnableSlave(activeMenu);
    }


}
