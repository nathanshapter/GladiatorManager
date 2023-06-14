using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlySpawner : MonoBehaviour
{
    BattleSceneSlaves battleSceneSlaves;
    [SerializeField] List<Character> battleSlaves = new List<Character>();

    [SerializeField] GameObject friendlyPrefab;
    void Start()
    {
        StartCoroutine(GetSlaveScript());


    }

    void ProcessSlaves()
    {
        battleSlaves = battleSceneSlaves.playerBattleSlaves;
   
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

    }
}
