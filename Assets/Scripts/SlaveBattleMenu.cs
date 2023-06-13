using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using TMPro;
using UnityEngine;

public class SlaveBattleMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI battle1, battle2, battle3;
    [SerializeField] TextMeshProUGUI[] opponentName1, opponentName2, opponentName3;
  //  [SerializeField] EnemyCharacter[] allOpponents;
    [SerializeField] List<EnemyCharacter> opponents1, opponents2, opponents3;
    [SerializeField] GameObject opponentNamePrefab;
    public List<EnemyCharacter> allOpponents;
 [SerializeField]   SelectSlaveMenu selectSlaveMenu;

    [SerializeField] int enemyAmountLimit = 4;
   
    private void Start()
    {
       
       
        RollOpponents();
      




    }

    public void RollOpponents() // tmp, tmp, list<enemycharacter>
    {
        GenerateOpponents(opponentName1, battle1, opponents1, true);
        GenerateOpponents(opponentName2, battle2,opponents2, false);
        GenerateOpponents(opponentName3, battle3, opponents3,false);
      
        
    }

    void GenerateOpponents(TMP_Text[] opponentNames, TMP_Text battleText, List<EnemyCharacter> enemyCharacterList, bool clearList)
    {
        if (clearList) { ClearEnemyList(); }   

        int amountOfEnemiesLimit = selectSlaveMenu.slaves.Length;
        if (amountOfEnemiesLimit == 0)
        {
            print("you need slaves to battle!");
            return;
        }
        if (amountOfEnemiesLimit > 4)
        {
            amountOfEnemiesLimit = enemyAmountLimit;
        }


        int amountOfEnemies = Random.Range(1, amountOfEnemiesLimit + 1);

        int amountOfCharacterSlaves = amountOfEnemies;

        for (int i = 0; i < opponentNames.Length; i++)
        {
            if (i < amountOfEnemies)
            {
                
                int numberOfEnemyCharacter = Random.Range(0, allOpponents.Count);
                opponentNames[i].text = allOpponents[numberOfEnemyCharacter].slaveName;

                enemyCharacterList.Add(allOpponents[numberOfEnemyCharacter]);
               
               
                
                allOpponents.RemoveAt(numberOfEnemyCharacter);
            }
            else
            {
                opponentNames[i].text = string.Empty;
            }
        }
        if (Random.Range(0, 100) > 75)
        {
            amountOfCharacterSlaves = 1;
        }
        battleText.text = $"{amountOfCharacterSlaves}v{amountOfEnemies}";
        CreateNewEnemyCharacter();

        if(enemyCharacterList.Count > amountOfEnemies) { enemyCharacterList.RemoveAt(0); }
        
    }

    private void ClearEnemyList()
    {
        opponents1.Clear();
        opponents2.Clear();
        opponents3.Clear();
    }

    void CreateNewEnemyCharacter()
    {
        if(allOpponents.Count <= 10)
        {
             EnemyCharacter maymaypoo = ScriptableObject.CreateInstance<EnemyCharacter>();
        allOpponents.Add(maymaypoo);
        }

      
    }
}
