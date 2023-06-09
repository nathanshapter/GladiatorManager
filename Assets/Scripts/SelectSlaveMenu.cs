using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SelectSlaveMenu : MonoBehaviour
{
    [SerializeField] GameObject[] slaveSelection;
    [SerializeField] GameObject[] slaveSelectionMenuUI;
    [SerializeField] GameObject mySlaves;
    [SerializeField] TextMeshProUGUI[] mySlaveText;
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

        foreach (var item in mySlaveText)
        {
            item.text = slaves[number].character.name;
            number++;
        }


        /*
         *    mySlaveText[0].text = slaves[0].character.name;
        mySlaveText[1].text = slaves[1].character.name;
        mySlaveText[2].text = slaves[2].character.name;
                foreach (var slave in slaves)
                {
                    slaveText += $"slave name is: {slave.character.name}, " ;
                    print(slave.character);
                }
                if (!string.IsNullOrEmpty(slaveText))
                {
                    slaveText = slaveText.Remove(slaveText.Length - 2);
                    slaveText += ".";
                }
               mySlavesText.text = slaveText;

             */

    }
    public void DisableMySlavesMenu()
    {
        mySlaves.gameObject.SetActive(false);
        EnableSlave(activeMenu);
    }


}
