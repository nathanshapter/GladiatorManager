using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "REPLACENAME")]
public class EnemyCharacter : ScriptableObject
{
    public string slaveName;
    public string slaveinfo;
    
    public int strength , defence , intelligence , charisma , agility , endurance,accuracy, resilience , leadership , luck ;
    public int maxStat;
    public int minStat;
   

    public GameObject slavePrefab;

    [ContextMenu("RandomizeStrength")]

    private void OnEnable()
    {

        strength = Random.Range(0, 10);
        defence = Random.Range(0, 10);
        intelligence = Random.Range(0, 10);
        charisma = Random.Range(0, 10);
        agility = Random.Range(0, 10);
        endurance = Random.Range(0, 10);
        accuracy = Random.Range(0, 10);
        resilience = Random.Range(0, 10);
        leadership = Random.Range(0, 10);
        luck = Random.Range(0, 10);

        slaveName = ReturnName();
    }
    public void RandomizeStrength()
    {
        strength = Random.Range(0, 10);
    }

    private string ReturnName()
    {
       string name = names[Random.Range(0, names.Length)];
        return name;
    }

    string[] names = new string[]
{
    "Marcus",
    "Lucius",
    "Gaius",
    "Titus",
    "Quintus",
    "Decimus",
    "Publius",
    "Tiberius",
    "Julius",
    "Flavius",
    "Aulus",
    "Cassius",
    "Augustus",
    "Valerius",
    "Appius",
    "Antonius",
    "Caius",
    "Claudius",
    "Crassus",
    "Decimus",
    "Drusus",
    "Felix",
    "Fabius",
    "Gnaeus",
    "Horatius",
    "Maximus",
    "Marius",
    "Octavius",
    "Pompeius",
    "Sextus",
    "Varius",
    "Vespasian",
    "Agrippa",
    "Marcellus",
    "Nero",
    "Otho",
    "Servius",
    "Sulla",
    "Verus",
    "Balbus",
    "Glabrio",
    "Cato",
    "Crassus",
    "Gallus",
    "Lentulus",
    "Mucius",
    "Nasica",
    "Paetus",
    "Plancus",
    "Pulcher",
    "Quirinus",
    "Rufus",
    "Scipio",
    "Silanus",
    "Vergilius",
    "Vibius",
    "Hostus",
    "Caecilius",
    "Cincius",
    "Hostilius",
    "Calidius",
    "Furio",
    "Decius",
    "Laelius",
    "Quinctius",
    "Salinator",
    "Stolo",
    "Aemilius",
    "Curius",
    "Flaccus",
    "Volumnius",
    "Vitellius",
    "Messala",
    "Blasius",
    "Atilius",
    "Cassius",
    "Verginius",
    "Vitruvius",
    "Fulvius",
    "Geminus",
    "Manilius",
    "Pontius",
    "Vibius",
    "Vopiscus",
    "Accius",
    "Agrippinus",
    "Albinius",
    "Barbatus",
    "Caesennius",
    "Egnatius",
    "Hostius",
    "Lentulus",
    "Ovidius",
    "Pansa",
    "Quirinius",
    "Rufinius",
    "Statius",
    "Tubero",
    "Ulpius",
    "Varro",
    "Vinicius",
    "Xanthus"
    // Add more names here...
};
}
