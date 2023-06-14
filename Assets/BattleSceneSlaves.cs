using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneSlaves : MonoBehaviour
{
    BattleSceneSlaves instance;

    SelectYourSlaves selectYourSlaves;
   [SerializeField]  List<Character> playerBattleSlaves = new List<Character>();
 [SerializeField]   List<EnemyCharacter> enemyBattleSlaves = new List<EnemyCharacter>();

    [SerializeField] GameObject enemyNPC;

    private void Awake()
    {
        if(instance !=null)
        {
            Destroy(gameObject); 
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
    }

    private void Start()
    {
        selectYourSlaves = FindObjectOfType<SelectYourSlaves>();
    }

 public   void CopyPlayerSlaves(List<Character> slavesToBattleWith)
    {
        playerBattleSlaves.Clear();
        playerBattleSlaves = slavesToBattleWith;
        foreach (var item in playerBattleSlaves)
        {
            print(item.slaveName);
        }
    }
    public void CopyEnemySlaves(List<EnemyCharacter> slavesToBattleAgainst)
    {
        enemyBattleSlaves.Clear();
        enemyBattleSlaves = slavesToBattleAgainst;
    }

   
}
