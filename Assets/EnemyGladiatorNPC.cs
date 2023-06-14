using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGladiatorNPC : MonoBehaviour
{
    AIDestinationSetter ai;
 public   EnemyCharacter enemyCharacter;

    private void Start()
    {
        ai = GetComponent<AIDestinationSetter>();
     //   ai.target = FindObjectOfType<GladiatorNPC>().transform;
    }

    private void Update()
    {
       
    }
}
