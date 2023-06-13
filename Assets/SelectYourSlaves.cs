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
    private void Start()
    {
       
        selectSlaveMenu = FindObjectOfType<SelectSlaveMenu>();
        dropDown = GetComponentInChildren<TMP_Dropdown>();
       
    }
  public void PopulateDropDown()
    {
        selectSlaveMenu.FindSlaves();
       
       
        List<Slave> slaveList = selectSlaveMenu.slaves.ToList();
        print(selectSlaveMenu.slaves.Length);
        List<TMP_Dropdown.OptionData> options = slaveList
            .Select(slave => new TMP_Dropdown.OptionData(slave.character.slaveName))
            .ToList();
        
        dropDown.options = options;
    }


    public void AddToBattleList()
    {
        activeOption = dropDown.value;
        print(activeOption);
    }
}
