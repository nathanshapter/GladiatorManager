using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SlaveBattleMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI battle1, battle2, battle3;
    [SerializeField] TextMeshProUGUI[] opponentName1, opponentName2, opponenentName3;
    [SerializeField] EnemyCharacter[] allOpponents;
    [SerializeField] EnemyCharacter[] opponent1, opponent2, opponent3;
    [SerializeField] GameObject opponentNamePrefab;

    private void Start()
    {
        int amountOfEnemies = Random.Range(1, 5);
        
        int amountOfCharacterSlaves = amountOfEnemies;

       if(amountOfEnemies== 4)
        {
            int numberOfEnemyCharacter1 = Random.Range(0, allOpponents.Length);
            int numberOfEnemyCharacter2 = Random.Range(0, allOpponents.Length);
            int numberOfEnemyCharacter3 = Random.Range(0, allOpponents.Length);
            int numberOfEnemyCharacter4 = Random.Range(0, allOpponents.Length);


            opponentName1[0].text = allOpponents[numberOfEnemyCharacter1].name;
            opponentName1[1].text = allOpponents[numberOfEnemyCharacter2].name;
            opponentName1[2].text = allOpponents[numberOfEnemyCharacter3].name;
            opponentName1[3].text = allOpponents[numberOfEnemyCharacter4].name;


           
        }
       else if(amountOfEnemies == 3)
        {
            int numberOfEnemyCharacter1 = Random.Range(0, allOpponents.Length);
            int numberOfEnemyCharacter2 = Random.Range(0, allOpponents.Length);
            int numberOfEnemyCharacter3 = Random.Range(0, allOpponents.Length);
            


            opponentName1[0].text = allOpponents[numberOfEnemyCharacter1].name;
            opponentName1[1].text = allOpponents[numberOfEnemyCharacter2].name;
            opponentName1[2].text = allOpponents[numberOfEnemyCharacter3].name;
            opponentName1[3].text = "nothing";
        }
       else if(amountOfEnemies == 2)
        {
            int numberOfEnemyCharacter1 = Random.Range(0, allOpponents.Length);
            int numberOfEnemyCharacter2 = Random.Range(0, allOpponents.Length);
           



            opponentName1[0].text = allOpponents[numberOfEnemyCharacter1].name;
            opponentName1[1].text = allOpponents[numberOfEnemyCharacter2].name;
            opponentName1[2].text = "nothing";
            opponentName1[3].text = "nothing";
        }
       else if(amountOfEnemies == 1)
        {
            int numberOfEnemyCharacter1 = Random.Range(0, allOpponents.Length);
           




            opponentName1[0].text = allOpponents[numberOfEnemyCharacter1].name;
            opponentName1[1].text = "nothing";
            opponentName1[2].text = "nothing";
            opponentName1[3].text = "nothing";
        }

        battle1.text = $"{amountOfCharacterSlaves}v{amountOfEnemies}";


        amountOfEnemies = Random.Range(1, 5);
        amountOfCharacterSlaves = amountOfEnemies;
        battle2.text = $"{amountOfCharacterSlaves}v{amountOfEnemies}";



        amountOfEnemies = Random.Range(1, 5);
        amountOfCharacterSlaves = amountOfEnemies;
        battle3.text = $"{amountOfCharacterSlaves}v{amountOfEnemies}";



        
      


       
    }
}
