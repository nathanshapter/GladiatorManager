using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
 [SerializeField]   BattleSceneSlaves battleSceneSlaves;

  public List<EnemyCharacter> enemyBattleSlaves = new List<EnemyCharacter>();
    [SerializeField] List<Character> friendlyBattleSlaves = new List<Character>();
    [SerializeField] GameObject enemyPrefab;


    // spawners need to hold array of all gladiatorNPC

    public List<EnemyGladiatorNPC> enemyGladiatorNPCs = new List<EnemyGladiatorNPC>();

    // Start is called before the first frame update
    void Start()
    {
      //  friendlySpawner = FindObjectOfType<FriendlySpawner>();
        StartCoroutine(GetSlaveScript());
    
       
    }

    void ProcessSlaves()
    {
        enemyBattleSlaves = battleSceneSlaves.enemyBattleSlaves;
        friendlyBattleSlaves = battleSceneSlaves.playerBattleSlaves;
        SpawnEnemyGladiator();
    }

    private IEnumerator GetSlaveScript()
    {
        yield return new WaitForSeconds(1);
        battleSceneSlaves = FindObjectOfType<BattleSceneSlaves>();
        yield return new WaitForSeconds(1);
        ProcessSlaves();
    }
    void SpawnEnemyGladiator()
    {
        foreach (var item in enemyBattleSlaves)
        {          

          
         GameObject newEnemy =    Instantiate(enemyPrefab, this.transform);

           newEnemy.GetComponent<EnemyGladiatorNPC>().enemyCharacter = item;
           StartCoroutine( SetTarget(newEnemy));

            enemyGladiatorNPCs.Add(newEnemy.GetComponent<EnemyGladiatorNPC>());
        }
    }

    IEnumerator SetTarget(GameObject newEnemy)
    {
        yield return new WaitForSeconds(2);
        Transform target = FindObjectOfType<FriendlySpawner>().playerGladiatorNPCs[0].transform;

        newEnemy.GetComponent<AIDestinationSetter>().target = target;
    }
}
