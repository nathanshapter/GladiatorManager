using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slave : MonoBehaviour
{
    public Character character;
    SlaveManager sm;
    private void Start()
    {
        sm = GetComponentInParent<SlaveManager>();
        character = sm.chosenCharacter;
    }
}
