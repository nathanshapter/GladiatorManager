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

    public int avgScore;


    public Sprite sprite;
    private void OnEnable()
    {

      //  strength = Random.Range(0, 10);
     //   defence = Random.Range(0, 10);
      //  intelligence = Random.Range(0, 10);
      //  charisma = Random.Range(0, 10);
      //  agility = Random.Range(0, 10);
      //  endurance = Random.Range(0, 10);
      //  accuracy = Random.Range(0, 10);
       // resilience = Random.Range(0, 10);
      //  leadership = Random.Range(0, 10);
      //  luck = Random.Range(0, 10);

       
        avgScore = Mathf.RoundToInt((strength + defence + intelligence + agility + endurance + accuracy + resilience + leadership + luck) / 10);
    }
}
