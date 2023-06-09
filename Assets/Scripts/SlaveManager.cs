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
       

       Instantiate(slavePrefab,this.transform);
        
        Slave slave = GetComponentInChildren<Slave>();

        slaves.Add(slave);
    
      
        
  
    }
}
