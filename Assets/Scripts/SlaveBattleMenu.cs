using JetBrains.Annotations;

using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class SlaveBattleMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI battle1, battle2, battle3;
    [SerializeField] TextMeshProUGUI[] opponentName1, opponentName2, opponentName3;
    [SerializeField] TextMeshProUGUI[] opponentAvgStat1, opponentAvgStat2, opponentAvgStat3;
    public int avgScore1, avgScore2, avgScore3;
  //  [SerializeField] EnemyCharacter[] allOpponents;
    public List<EnemyCharacter> opponents1, opponents2, opponents3;
    [SerializeField] GameObject opponentNamePrefab;
    public List<EnemyCharacter> allOpponents;
 [SerializeField]   SelectSlaveMenu selectSlaveMenu;

    [SerializeField] int enemyAmountLimit = 4;
   public int slaveAmountToPass1, slaveAmountToPass2, slaveAmountToPass3;

    BattleSceneSlaves battleSceneSlaves;

    SelectYourSlaves selectYourSlaves;

  [SerializeField]  public List<SpriteRenderer> opponentImage1, opponentImage2, opponentImage3;
   

 
    private void Start()
    {
       battleSceneSlaves = FindObjectOfType<BattleSceneSlaves>();
        selectYourSlaves = FindObjectOfType<SelectYourSlaves>();
       
        RollOpponents();
      




    }

    public void RollOpponents() // tmp, tmp, list<enemycharacter>
    {
        GenerateOpponents(opponentName1, battle1, opponents1, true, 1, opponentAvgStat1, avgScore1, opponentImage1);
        GenerateOpponents(opponentName2, battle2,opponents2, false,2, opponentAvgStat2, avgScore2, opponentImage2);
        GenerateOpponents(opponentName3, battle3, opponents3,false,3, opponentAvgStat3, avgScore3, opponentImage3);
      
        
    }

    void GenerateOpponents(TMP_Text[] opponentNames, TMP_Text battleText, List<EnemyCharacter> enemyCharacterList, bool clearList, int slaveInt, TMP_Text[] avgStatText, int avgScore, List<SpriteRenderer> sprite)
    {
        CreateNewEnemyCharacter();
        avgScore = 0;
        if (clearList) { ClearEnemyList(); }

        int amountOfEnemiesLimit = selectSlaveMenu.slaves.Length;
        if (amountOfEnemiesLimit == 0)
        {
            print("You need slaves to battle!");
            return;
        }
        if (amountOfEnemiesLimit > enemyAmountLimit)
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
                avgStatText[i].text = " Avg stat: " + allOpponents[numberOfEnemyCharacter].avgScore.ToString();
                enemyCharacterList.Add(allOpponents[numberOfEnemyCharacter]);
                sprite[i].sprite = allOpponents[numberOfEnemyCharacter].characterSprite;
                avgScore += allOpponents[numberOfEnemyCharacter].avgScore;
                allOpponents.RemoveAt(numberOfEnemyCharacter);
            }
            else
            {
                opponentNames[i].text = string.Empty;
                avgStatText[i].text = string.Empty;
                sprite[i].sprite = null; // Clear the sprite for the unused slots
            }
        }

        avgScore /= amountOfEnemies;

        int numberToUse = Random.Range(0, 100);
        if (numberToUse > 75)
        {
            amountOfCharacterSlaves = 1;
        }
        else if (numberToUse < 25 && amountOfCharacterSlaves > 1)
        {
            amountOfCharacterSlaves = 2;
        }

        battleText.text = $"{amountOfCharacterSlaves}v{amountOfEnemies}";
        

        if (enemyCharacterList.Count > amountOfEnemies)
        {
            enemyCharacterList.RemoveAt(0);
        }

        switch (slaveInt)
        {
            case 1:
                slaveAmountToPass1 = amountOfCharacterSlaves;
                avgScore1 = avgScore;
                break;
            case 2:
                slaveAmountToPass2 = amountOfCharacterSlaves;
                avgScore2 = avgScore;
                break;
            case 3:
                slaveAmountToPass3 = amountOfCharacterSlaves;
                avgScore3 = avgScore;
                break;
        }
    }

    private void ClearEnemyList()
    {
        opponents1.Clear();
        opponents2.Clear();
        opponents3.Clear();
    }

    void CreateNewEnemyCharacter()
    {
        if(allOpponents.Count <= 20)
        {
            int howmanyToCreate = 20;

            for (int i = 0; i < howmanyToCreate; i++)
            {
                EnemyCharacter maymaypoo = ScriptableObject.CreateInstance<EnemyCharacter>();
                allOpponents.Add(maymaypoo);
            }


           
        }

      
    }
}
