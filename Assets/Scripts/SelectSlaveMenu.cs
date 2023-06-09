using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SelectSlaveMenu : MonoBehaviour
{
    [SerializeField] GameObject[] slaveSelection;
    [SerializeField] GameObject mySlaves;
    [SerializeField] TextMeshProUGUI mySlavesText;
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
    private void EnableSlave(int i)
    {
       
        slaveSelection[i].gameObject.SetActive(true);
       
    }
    public void MySlavesMenu()
    {
        DisableAllSlaveSelection();
        mySlaves.gameObject.SetActive(true);
        Slave[] slaves = FindObjectsOfType<Slave>();

       

        foreach (var slave in slaves)
        {
            slaveText += $"slave name is: {slave.character.name}, " ;
            print(slave.character);
        }
       mySlavesText.text = slaveText;

     
       
    }

}
