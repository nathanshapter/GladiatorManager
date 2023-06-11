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
    public int maxStat;
    public int minStat;


    public GameObject slavePrefab;
 
}
