using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectYourSlaves : MonoBehaviour
{
  [SerializeField]  TMP_Dropdown dropDown;
    SelectSlaveMenu selectSlaveMenu;
    int activeOption;


    List<Slave> slavesTobattleWith = new List<Slave>();
    int slaveMax;
    private void Start()
    {
       
        selectSlaveMenu = FindObjectOfType<SelectSlaveMenu>();
        dropDown = GetComponentInChildren<TMP_Dropdown>();
      
       
    }
  public void PopulateDropDown(int i)
    {


        selectSlaveMenu.FindSlaves();
       
       
        List<Slave> slaveList = selectSlaveMenu.slaves.ToList();
        print(selectSlaveMenu.slaves.Length);
        List<TMP_Dropdown.OptionData> options = slaveList
            .Select(slave => new TMP_Dropdown.OptionData(slave.character.slaveName))
            .ToList();
        
        dropDown.options = options;
        slaveMax = i;
        print($" Please select {slaveMax} slaves ");
    }


    public void AddToBattleList()
    {
       

        activeOption = dropDown.value;
        Slave selectedSlave = selectSlaveMenu.slaves[activeOption];
        slavesTobattleWith.Add(selectedSlave);
        print(selectedSlave.character.name);
        



        
    }
}
