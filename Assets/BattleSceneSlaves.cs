using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneSlaves : MonoBehaviour
{
    BattleSceneSlaves instance;

    SelectYourSlaves selectYourSlaves;
    List<Slave> battleSlaves = new List<Slave>();

    private void Awake()
    {
        if(instance !=null)
        {
            Destroy(gameObject); 
        }
        else
        {
            instance = this;
        }
    }

    private void Start()
    {
        selectYourSlaves = FindObjectOfType<SelectYourSlaves>();
    }

 public   void CopySlaves(List<Slave> slavesToBattleWith)
    {
        battleSlaves.Clear();
        battleSlaves = slavesToBattleWith;
        foreach (var item in battleSlaves)
        {
            print(item.character.slaveName);
        }
    }
}
