using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(fileName = "REPLACENAME")]
public class Character : ScriptableObject
{
    public string slaveName;
    public string slaveinfo;
    public int slavePrice;
    public int strength, defence, intelligence, charisma, agility, endurance, accuracy, resilience, leadership, luck;
   


    public GameObject slavePrefab;

    public int avgStat;


    public Sprite sprite;

   public GameObject replacementSlavePrefab;


    // stats are not randomised, but will have to take in the date to set randomised values in future
    private void OnEnable() 
    {    

       
        avgStat = Mathf.RoundToInt((strength + defence + intelligence + agility + endurance + accuracy + resilience + leadership + luck) / 10);
    }
}
