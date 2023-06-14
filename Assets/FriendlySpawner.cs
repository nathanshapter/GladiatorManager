using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlySpawner : MonoBehaviour
{
    BattleSceneSlaves battleSceneSlaves;
    public List<Character> friendlyBattleSlaves = new List<Character>();
    [SerializeField] List<EnemyCharacter> enemyBattleSlaves = new List<EnemyCharacter>();
    [SerializeField] GameObject friendlyPrefab;


   public List<PlayerGladiatorNPC> playerGladiatorNPCs = new List<PlayerGladiatorNPC>();
   
    void Start()
    {
      //  enemySpawner = FindObjectOfType<EnemySpawner>();
        StartCoroutine(GetSlaveScript());


    }

    void ProcessSlaves()
    {
        friendlyBattleSlaves = battleSceneSlaves.playerBattleSlaves;
        enemyBattleSlaves = battleSceneSlaves.enemyBattleSlaves;
        SpawnFriendlyGladiators();
    }

    private IEnumerator GetSlaveScript()
    {
        yield return new WaitForSeconds(1);
        battleSceneSlaves = FindObjectOfType<BattleSceneSlaves>();
        yield return new WaitForSeconds(1);
        ProcessSlaves();
    }

    void SpawnFriendlyGladiators()
    {
        foreach (var item in friendlyBattleSlaves)
        {


            GameObject newFriendly = Instantiate(friendlyPrefab, this.transform);
            newFriendly.GetComponent<PlayerGladiatorNPC>().character = item;
         StartCoroutine(SetTarget(newFriendly));
           playerGladiatorNPCs.Add(newFriendly.GetComponent<PlayerGladiatorNPC>());
        }
    }


    IEnumerator SetTarget(GameObject newFriendly)
    {
        yield return new WaitForSeconds(2);
        Transform target = FindObjectOfType<EnemySpawner>().enemyGladiatorNPCs[0].transform;

        newFriendly.GetComponent<AIDestinationSetter>().target = target;
    }
}
