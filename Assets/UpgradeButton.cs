using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
   [SerializeField] Slave slave;
    Button button;
    SelectSlaveMenu slaveMenu;
    [SerializeField] int slaveNumber = 0;
    private void Start()
    {
        slaveMenu= GetComponentInParent<SelectSlaveMenu>();
        button= GetComponent<Button>();
        
       

    }

  public  void GetSlave()
    {
        if (slaveNumber >= slaveMenu.slaves.Length)
        {
            return;
        }

        slave = slaveMenu.slaves[slaveNumber];
        print("button" + slave.character.name);
    }


     public void UpgradeSlaveAttribute(int attributeName)
      {
        switch(attributeName)
          {
              case 1: //strength
                  slave.character.strength += 50;
                  print(slave.character.name + " upgraded strength to " + slave.character.strength);
                  break;
              case 2: // Intelligence
                  slave.character.intelligence += 50;
                  print(slave.character.name + " upgraded intelligence to " + slave.character.intelligence);
                  break;
              default:
                  print("Invalid attribute ID.");
                  break;
          }
      }



}
