using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneSlaves : MonoBehaviour
{
    static BattleSceneSlaves instance;

    SelectYourSlaves selectYourSlaves;
  public  List<Character> playerBattleSlaves = new List<Character>();
 public  List<EnemyCharacter> enemyBattleSlaves = new List<EnemyCharacter>();

    [SerializeField] GameObject enemyNPC;

    private void Awake()
    {
       
        if(instance ==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
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
            print(item.slaveName + " has been passed to battleSceneSlaves.");
        }
    }
    public void CopyEnemySlaves(List<EnemyCharacter> slavesToBattleAgainst)
    {
        enemyBattleSlaves.Clear();
        enemyBattleSlaves = slavesToBattleAgainst;
    }

   
}
