using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SlaveBattleMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI battle1, battle2, battle3;
    [SerializeField] TextMeshProUGUI opponentInfo1, opponentInfo2, opponenentInfo3;
    [SerializeField] EnemyCharacter[] allOpponents;
    [SerializeField] EnemyCharacter[] opponent1, opponent2, opponent3;

    private void Start()
    {
        battle1.text = "1v1";
        battle2.text = "1v5";
        battle3.text = "1v2";

        opponentInfo1.text = opponent1[0].name;

    }
}
