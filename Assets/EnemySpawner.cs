using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
 [SerializeField]   BattleSceneSlaves battleSceneSlaves;

  [SerializeField] List<EnemyCharacter> battleSlaves = new List<EnemyCharacter>();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetSlaveScript());
    
       
    }

    void ProcessSlaves()
    {
        battleSlaves = battleSceneSlaves.enemyBattleSlaves;
        print("test");
    }

    private IEnumerator GetSlaveScript()
    {
        yield return new WaitForSeconds(1);
        battleSceneSlaves = FindObjectOfType<BattleSceneSlaves>();
        yield return new WaitForSeconds(1);
        ProcessSlaves();
    }
}
