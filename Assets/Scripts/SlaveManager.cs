using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlaveManager : MonoBehaviour
{
    List<Slave> slaves = new List<Slave>();


    public Character chosenCharacter;
    [SerializeField] GameObject slavePrefab;

   public void newSlave(Character c)
    {
        print(c.name);

       Instantiate(slavePrefab,this.transform);
        
        Slave slave = GetComponentInChildren<Slave>();

        slaves.Add(slave);
        slaves[0].c = chosenCharacter;
       
        
        print($"it went through as {slaves[0].c.name}");
    }
}
