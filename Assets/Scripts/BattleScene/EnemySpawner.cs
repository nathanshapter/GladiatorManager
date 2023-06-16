using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    /// <summary>
    /// This script spawns enemies based on the battlesceneSlaves script.
    /// it used the referenced script to spawn enemies in a certain distance from each other
    /// sister script is FriendlySpawner
    /// </summary>


    [SerializeField]   BattleSceneSlaves battleSceneSlaves;

    // this is an exact copy of battle scene slaves
    public List<EnemyCharacter> enemyBattleSlaves = new List<EnemyCharacter>(); 
    [SerializeField] List<Character> friendlyBattleSlaves = new List<Character>();

    // this is used to take in the enemy gladiators that are spawned, and to remove them once they die
    public List<EnemyGladiatorNPC> enemyGladiatorNPCs = new List<EnemyGladiatorNPC>();

    // spawnedge to clamp in where they will spawn, onevsone spawn used for when there is only one enemy on either side
    [SerializeField] Transform spawnEdge1, spawnEdge2, oneVSoneSpawn;
    [SerializeField] float spawnRange;
    [SerializeField] GameObject enemyPrefab;
     void Start()
    {     
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

        int numberOfEnemies = enemyBattleSlaves.Count;

        for (int i = 0; i < numberOfEnemies; i++)
        {
            GameObject newEnemy = Instantiate(enemyPrefab, this.transform);

            newEnemy.GetComponent<EnemyGladiatorNPC>().enemyCharacter = enemyBattleSlaves[i];

            float t = (float)i / (numberOfEnemies - 1); // Normalized value between 0 and 1

            // Use a curve to adjust the spawn position bias
            float curveValue = Mathf.Pow(1f - t, 2f);

            // Lerp between the two spawn edges with the adjusted bias
            Vector3 spawnPosition = Vector3.Lerp(spawnEdge1.position, spawnEdge2.position, curveValue);

            // Apply some randomness to the spawn position within the spawn range
            spawnPosition += Random.insideUnitSphere * spawnRange;

            // Clamp the Y-axis position to ensure it stays within the desired range
            
            spawnPosition.y = Mathf.Clamp(spawnPosition.y, spawnEdge1.position.y, spawnEdge2.position.y);

         
            if(numberOfEnemies == 1)
            {
                spawnPosition = oneVSoneSpawn.position;
            }
            // Set the position of the new enemy

            newEnemy.transform.position = spawnPosition;
            
            

            StartCoroutine(SetTarget(newEnemy));
            enemyGladiatorNPCs.Add(newEnemy.GetComponent<EnemyGladiatorNPC>());
        }
    }


    // this method waits two seconds after spawning the NPC's to allow the others to spawn, they currently only go for one enemy , shall eventually have randomised targets, and will
    // attack the enemy that is closest to them, and then the one that hits them
    IEnumerator SetTarget(GameObject newEnemy)
    {
        yield return new WaitForSeconds(2);
        Transform target = FindObjectOfType<FriendlySpawner>().playerGladiatorNPCs[0].transform;

        newEnemy.GetComponent<AIDestinationSetter>().target = target;
    }
}
