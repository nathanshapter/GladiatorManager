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
      //  if(Vector2.Distance(this.transform.position, ai.target.transform.position) < 3)
        {
          //  ai.target.GetComponent<GladiatorNPC>().health -= 10;
        //    print(ai.target.GetComponent<GladiatorNPC>().health);
        }
    }
}
