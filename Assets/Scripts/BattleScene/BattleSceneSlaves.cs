using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneSlaves : MonoBehaviour
{
    static BattleSceneSlaves instance;

    public  List<Character> playerBattleSlaves = new List<Character>();
    public  List<EnemyCharacter> enemyBattleSlaves = new List<EnemyCharacter>();

   
    /// <summary>
    /// The purpose of this script is to be given the slaves that were chosen for battle in the battle menu
    /// These slaves count are then used to spawn the correct amount of player gladiators and enemy gladiators
    /// </summary>

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

 public   void CopyPlayerSlaves(List<Character> slavesToBattleWith)
    {
        playerBattleSlaves.Clear();
        playerBattleSlaves = slavesToBattleWith;
        foreach (var item in playerBattleSlaves)
        {
            print(item.slaveName + " has been passed to battleSceneSlaves.");
        }
    }


    // 3 references because there are 3 possible battles. It is only called once and copies the slaves from the battle that was selected
    public void CopyEnemySlaves(List<EnemyCharacter> slavesToBattleAgainst) 
    {
        enemyBattleSlaves.Clear();
        enemyBattleSlaves = slavesToBattleAgainst;
    }

   
}
