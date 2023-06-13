using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptBattle : MonoBehaviour
{
   SlaveBattleMenu slavebattleMenu;
    SelectSlaveMenu SelectSlaveMenu;

    [SerializeField] SelectYourSlaves selectYourSlavesForBattle;

    private void Start()
    {
        slavebattleMenu= GetComponentInParent<SlaveBattleMenu>();
        SelectSlaveMenu= GetComponentInParent<SelectSlaveMenu>();
        selectYourSlavesForBattle = FindObjectOfType<SelectYourSlaves>();
    }

    public void AcceptSlaveBattle(int i) // the i is to be chosen in button inspector to say the battle you want to accept
    {
        switch(i)
        {
            case 0:
                print("opponents count: "+ slavebattleMenu.opponents1.Count);
                OpenSlaveSelectForFight(i);
                break;
            case 1:
                print("opponents count: " + slavebattleMenu.opponents2.Count);
                OpenSlaveSelectForFight(i);
                break;
                case 2:
                print("opponents count: " + slavebattleMenu.opponents3.Count);
                OpenSlaveSelectForFight(i); 
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
             
                break;
            case 1:
                print("choose your slaves " + slavebattleMenu.slaveAmountToPass2);
               
                break;
            case 2:

                print("choose your slaves " + slavebattleMenu.slaveAmountToPass3);
                break;

        }



        selectYourSlavesForBattle.PopulateDropDown();
   

      
    }
}
