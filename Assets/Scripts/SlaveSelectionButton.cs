using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SlaveSelectionButton : MonoBehaviour
{
 
    [SerializeField] TextMeshProUGUI buttonText, infoText;

    public Character character;

    private void Start()
    {
        infoText.text = $"The slave price is {character.slavePrice}";
    }



}
