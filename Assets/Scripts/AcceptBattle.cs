using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptBattle : MonoBehaviour
{
   SlaveBattleMenu slavebattleMenu;

    private void Start()
    {
        slavebattleMenu= GetComponentInParent<SlaveBattleMenu>();
    }

    public void AcceptSlaveBattle()
    {

    }
}
