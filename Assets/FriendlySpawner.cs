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

    [SerializeField] Transform spawnEdge1, spawnEdge2, oneVSOneSpawn;
    [SerializeField] float spawnRange;

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
        int numberOfFriendlies = friendlyBattleSlaves.Count;

        for (int i = 0; i < numberOfFriendlies; i++)
        {
            GameObject newFriendly = Instantiate(friendlyPrefab, this.transform);
            newFriendly.GetComponent<PlayerGladiatorNPC>().character= friendlyBattleSlaves[i];

            float t = (float)i/ (numberOfFriendlies -1);

            float curveValue = Mathf.Pow(1f - t, 2f);

            Vector3 spawnPosition = Vector3.Lerp(spawnEdge1.position, spawnEdge2.position, curveValue);

            spawnPosition += Random.insideUnitSphere * spawnRange;
            spawnPosition.y = Mathf.Clamp(spawnPosition.y, spawnEdge1.position.y, spawnEdge2.position.y);

        if(numberOfFriendlies == 1)
            {
                spawnPosition = oneVSOneSpawn.position;
            }

            newFriendly.transform.position = spawnPosition;
            


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
