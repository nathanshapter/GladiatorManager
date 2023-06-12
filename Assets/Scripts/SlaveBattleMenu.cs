using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SlaveBattleMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI battle1, battle2, battle3;
    [SerializeField] TextMeshProUGUI[] opponentName1, opponentName2, opponentName3;
  //  [SerializeField] EnemyCharacter[] allOpponents;
    [SerializeField] EnemyCharacter[] opponent1, opponent2, opponent3;
    [SerializeField] GameObject opponentNamePrefab;
    public List<EnemyCharacter> allOpponents;

    private void Start()
    {

        RollOpponents();
      




    }

    public void RollOpponents()
    {
        GenerateOpponents(opponentName1, battle1);
        GenerateOpponents(opponentName2, battle2);
        GenerateOpponents(opponentName3, battle3);
    }

    void GenerateOpponents(TMP_Text[] opponentNames, TMP_Text battleText)
    {
        int amountOfEnemies = Random.Range(1, 5);

        int amountOfCharacterSlaves = amountOfEnemies;

        for (int i = 0; i < opponentNames.Length; i++)
        {
            if (i < amountOfEnemies)
            {
                int numberOfEnemyCharacter = Random.Range(0, allOpponents.Count);
                opponentNames[i].text = allOpponents[numberOfEnemyCharacter].slaveName;
                print(allOpponents[numberOfEnemyCharacter].slaveName + allOpponents[numberOfEnemyCharacter].strength);
                allOpponents.RemoveAt(numberOfEnemyCharacter);
            }
            else
            {
                opponentNames[i].text = string.Empty;
            }
        }
        battleText.text = $"{amountOfCharacterSlaves}v{amountOfEnemies}";
    }
   

}
