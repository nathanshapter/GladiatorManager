using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSlaveMenu : MonoBehaviour
{
    [SerializeField] GameObject[] slaveSelection;
    int activeMenu = 0;

    private void Start()
    {
        DisableAll();
        EnableSlave(activeMenu);
        
    }

    public void PreviousSlave()
    {
        DisableAll();
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
        DisableAll();
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

    private void DisableAll()
    {
        foreach (var item in slaveSelection)
        {
            item.gameObject.SetActive(false);
        }
    }
    private void EnableSlave(int i)
    {
       
        slaveSelection[i].gameObject.SetActive(true);
        print(activeMenu);
    }

}
