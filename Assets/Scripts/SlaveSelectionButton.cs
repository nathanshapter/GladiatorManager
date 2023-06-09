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
        buttonText.text = character.slaveName + $" The price is {character.slavePrice}";
        infoText.text = $"This slaves stats are Strength: {character.strength}, Defence: {character.defence}, Intelligence: {character.intelligence}," +
            $"Charisma: {character.charisma}, Agility: {character.agility}, Endurance: {character.endurance}, Accuracy: {character.accuracy}," +
            $"Resilience: {character.resilience}, Leadership: {character.leadership}, Luck: {character.luck} " +
            $"There Max stat is {character.maxStat}, and minimum stat is {character.minStat}";
    }



}
