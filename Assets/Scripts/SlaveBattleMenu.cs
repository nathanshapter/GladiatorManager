using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SlaveBattleMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI battle1, battle2, battle3;
    [SerializeField] TextMeshProUGUI opponentName1, opponentName2, opponenentName3;
    [SerializeField] EnemyCharacter[] allOpponents;
    [SerializeField] EnemyCharacter[] opponent1, opponent2, opponent3;

    private void Start()
    {
        int amountOfEnemies = Random.Range(1, 5);
        int amountOfCharacterSlaves = amountOfEnemies;



        battle1.text = $"{amountOfCharacterSlaves}v{amountOfEnemies}";
        amountOfEnemies = Random.Range(1, 5);
        amountOfCharacterSlaves = amountOfEnemies;
        battle2.text = $"{amountOfCharacterSlaves}v{amountOfEnemies}";
        amountOfEnemies = Random.Range(1, 5);
        amountOfCharacterSlaves = amountOfEnemies;
        battle3.text = $"{amountOfCharacterSlaves}v{amountOfEnemies}";
        
        int numberOfEnemyCharacter = Random.Range(0, allOpponents.Length);

        opponentName1.text = allOpponents[numberOfEnemyCharacter].name;
        
    }
}
