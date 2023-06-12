using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "REPLACENAME")]
public class EnemyCharacter : ScriptableObject
{
    public string slaveName;
    public string slaveinfo;
    
    public int strength , defence , intelligence , charisma , agility , endurance,accuracy, resilience , leadership , luck ;
    public int maxStat;
    public int minStat;


    public GameObject slavePrefab;

    [ContextMenu("RandomizeStrength")]

    private void OnEnable()
    {
        strength = Random.Range(0, 10);
        defence = Random.Range(0, 10);
        intelligence = Random.Range(0, 10);
        charisma = Random.Range(0, 10);
        agility = Random.Range(0, 10);
        endurance = Random.Range(0, 10);
        accuracy = Random.Range(0, 10);
        resilience = Random.Range(0, 10);
        leadership = Random.Range(0, 10);
        luck = Random.Range(0, 10);
    }
    public void RandomizeStrength()
    {
        strength = Random.Range(0, 10);
    }
}
