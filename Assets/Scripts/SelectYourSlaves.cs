using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SelectYourSlaves : MonoBehaviour
{
  [SerializeField]  TMP_Dropdown dropDown;
    SelectSlaveMenu selectSlaveMenu;
    int activeOption;
    BattleSceneSlaves battleSceneSlaves;

    List<Character> slavesTobattleWith = new List<Character>();
    int slaveMax;
    [SerializeField] TextMeshProUGUI slavesRemaining;

    [SerializeField] TextMeshProUGUI buttonText;
    public TextMeshProUGUI enemyAvgSkillText;
    SlaveBattleMenu slaveBattleMenu;
    int amountOfSlavesSelected;
    private void Start()
    {
       
        selectSlaveMenu = FindObjectOfType<SelectSlaveMenu>();
        dropDown = GetComponentInChildren<TMP_Dropdown>();
      battleSceneSlaves= FindObjectOfType<BattleSceneSlaves>();
        slaveBattleMenu = FindObjectOfType<SlaveBattleMenu>();
       
    }
  public void PopulateDropDown(int i)
    {
        

        selectSlaveMenu.FindSlaves();


        List<Slave> slaveList = selectSlaveMenu.slaves.ToList();
        List<TMP_Dropdown.OptionData> options = slaveList.Select(slave =>
            new TMP_Dropdown.OptionData($"{slave.character.slaveName} - Avg Skill: {slave.character.avgScore}")
        ).ToList();

        dropDown.options = options;
        slaveMax = i;

        if(slaveMax == 1)
        {
            slavesRemaining.text = $" Please select {slaveMax} slave ";
        }
        else
        {
            slavesRemaining.text = $" Please select {slaveMax} slaves ";
        }

       
       

    //    enemyAvgScoreText.text = slaveBattleMenu.avgScoreToPass.ToString();
    }


    public void AddToBattleList()
    {

        activeOption = dropDown.value;
        Slave selectedSlave = selectSlaveMenu.slaves[activeOption];

        if (slavesTobattleWith.Count == slaveMax)
        {
          
            
            SceneManager.LoadScene(1);
            // load scene
            return;
        }

        // Check if the selected slave's name has already been added
        if (slavesTobattleWith.Exists(slave => slave.name == selectedSlave.character.name))
        {
            slavesRemaining.text = $"{selectedSlave.character.slaveName} has already been added to the battle. ";
            return;
        }

        slavesTobattleWith.Add(selectedSlave.character);
     
        amountOfSlavesSelected++;
        slavesRemaining.text = ("You have selected " + selectedSlave.character.slaveName + $" Please select {slaveMax - amountOfSlavesSelected} more.");
        if (slavesTobattleWith.Count == slaveMax)
        {
           slavesRemaining.text =  "You have selected the correct amount of slaves. Prepare for battle";
            buttonText.text = "Begin battle";
            foreach (var item in slavesTobattleWith)
            {
                print("You have Selected " + item.name);
            }
            battleSceneSlaves.CopyPlayerSlaves(slavesTobattleWith);
        }


    }
}
