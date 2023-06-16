using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptBattle : MonoBehaviour
{
    SlaveBattleMenu slavebattleMenu;
    SelectSlaveMenu SelectSlaveMenu;
    SelectYourSlaves selectYourSlavesForBattle;
    BattleSceneSlaves battleSceneSlaves;

    /// <summary>
    /// The purpose of this script is to pass in the information from the battle that you chose to the battlesceneslaves so that
    /// the correct amount of slaves can be spawned with their correct stats
    /// </summary>

    private void Start()
    {
        slavebattleMenu= GetComponentInParent<SlaveBattleMenu>();
        SelectSlaveMenu= GetComponentInParent<SelectSlaveMenu>();
        selectYourSlavesForBattle = FindObjectOfType<SelectYourSlaves>();
        battleSceneSlaves= FindObjectOfType<BattleSceneSlaves>();
    }

    // the i is to be chosen in button inspector to say the battle you want to accept
    // the buttons that use then then pass it into openslaveslectforfight which then gives the avg stats of the enemy team, and populates the dropdown
    //with your slaves
    public void AcceptSlaveBattle(int i)
    {
        switch(i)
        {
            case 0:
                print("opponents count: "+ slavebattleMenu.opponents1.Count);
                OpenSlaveSelectForFight(i);
                battleSceneSlaves.CopyEnemySlaves(slavebattleMenu.opponents1);
                break;
            case 1:
                print("opponents count: " + slavebattleMenu.opponents2.Count);
                OpenSlaveSelectForFight(i);
                battleSceneSlaves.CopyEnemySlaves(slavebattleMenu.opponents2);
                break;
                case 2:
                print("opponents count: " + slavebattleMenu.opponents3.Count);
                OpenSlaveSelectForFight(i);
                battleSceneSlaves.CopyEnemySlaves(slavebattleMenu.opponents3);
                break;
                
        }
        selectYourSlavesForBattle.gameObject.SetActive(true);
    }
    void OpenSlaveSelectForFight(int i)
    {
        SelectSlaveMenu.DisableEverything(true);       


        switch (i)
        {
            case 0:
                print("choose your slaves " + slavebattleMenu.slaveAmountToPass1);
                selectYourSlavesForBattle.PopulateDropDown(slavebattleMenu.slaveAmountToPass1);
                selectYourSlavesForBattle.enemyAvgSkillText.text = $"Enemy team skill avg: {slavebattleMenu.avgScore1}";
                break;
            case 1:
                print("choose your slaves " + slavebattleMenu.slaveAmountToPass2);
                selectYourSlavesForBattle.PopulateDropDown(slavebattleMenu.slaveAmountToPass2);
                selectYourSlavesForBattle.enemyAvgSkillText.text = $"Enemy team skill avg: {slavebattleMenu.avgScore2}";
                break;
            case 2:

                print("choose your slaves " + slavebattleMenu.slaveAmountToPass3);
                selectYourSlavesForBattle.PopulateDropDown(slavebattleMenu.slaveAmountToPass3);
                selectYourSlavesForBattle.enemyAvgSkillText.text = $"Enemy team skill avg: {slavebattleMenu.avgScore3}";
                break;
        }      
   

      
    }
}
