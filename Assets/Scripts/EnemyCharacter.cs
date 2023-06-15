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
        avgScore = Mathf.RoundToInt((strength+defence+intelligence+agility+endurance+accuracy+resilience+leadership+luck)/10);
    }
    public int avgScore;

   
    
    private string ReturnName()
    {
       string name = names[Random.Range(0, names.Length)];
        return name;
    }

    string[] names = new string[]
{
    "Aemilius", "Aelianus", "Aelius", "Aemilianus", "Aeneas", "Africanus", "Agrippa", "Albinus", "Alexander", "Ambrosius",
    "Anicetus", "Antonius", "Apollonius", "Aquilinus", "Aristides", "Aurelius", "Aureolus", "Aureus", "Avitus", "Balbus",
    "Basilides", "Caecilianus", "Caesar", "Caius", "Caligula", "Cassius", "Castor", "Cato", "Celsus", "Cicero",
    "Claudianus", "Claudius", "Commodus", "Constantinus", "Cornelius", "Crispus", "Cyprianus", "Dacianus", "Decimus", "Didius",
    "Diocletianus", "Diogenes", "Domitianus", "Drusus", "Emilianus", "Eugenius", "Eusebius", "Faustus", "Felix", "Flavius",
    "Gaius", "Galba", "Gallus", "Germanicus", "Gordianus", "Hadrianus", "Helius", "Honorius", "Horatius", "Julianus",
    "Julius", "Justinianus", "Laelianus", "Lucianus", "Lucius", "Macrinus", "Magnus", "Marcellinus", "Marcellus", "Marcus",
    "Maximianus", "Maximinus", "Maximus", "Nero", "Nerva", "Octavianus", "Octavius", "Olybrius", "Pertinax", "Plautianus",
    "Pompeius", "Pontius", "Quintilianus", "Quintillus", "Quintus", "Regulus", "Romulus", "Rufus", "Sabianus", "Saturninus",
    "Severus", "Sextus", "Solinus", "Tacitus", "Tarquinius", "Tertius", "Theodosius", "Tiberius", "Titus", "Traianus",
    "Urbanus", "Valens", "Valentinianus", "Valerianus", "Varus", "Verus", "Vespasianus", "Victor", "Vitellius", "Vitus",
    "Abercius", "Abundius", "Accius", "Adelphus", "Aelianus", "Aemilianus", "Aemilius", "Aequitius", "Afer", "Agathinus",
    "Agelastus", "Agrippa", "Albinus", "Albus", "Alexander", "Alexius", "Allectus", "Amandus", "Ambrosius", "Ammianus",
    "Ammonius", "Amulius", "Anatolius", "Anatolus", "Andronicus", "Andronicus", "Annianus", "Anterus", "Anthimus", "Antigonus",
    "Antiochus", "Antoninus", "Antonius", "Apollinaris", "Apollonius", "Appianus", "Apronianus", "Aquilius", "Aquilius", "Aquilinus",
    "Arbogastes", "Arcadius", "Artemas", "Asclepiades", "Asclepiodotus", "Asclepiodotus", "Asclepius", "Astyrius", "Attianus", "Atticus",
    "Atticus", "Attilius", "Augustus", "Aurelianus", "Aurelius", "Auruncus", "Avienus", "Avitus", "Axioponus", "Axius",
    "Babrianus", "Balbinus", "Barbatus", "Bassianus", "Bassus", "Bato", "Belisarius", "Benedictus", "Berenicianus", "Bessus",
    "Boethius", "Bonifatius", "Brutus", "Bucellinus", "Caecilianus", "Caecina", "Caecinatus", "Caecus", "Caepio", "Caepio",
    "Caesar", "Caligula", "Calpurnius", "Candidianus", "Candidus", "Canio", "Capella", "Capito", "Capitolinus", "Cassianus",
    "Cassiodorus", "Castinus", "Castor", "Catalinus", "Catianus", "Catilina", "Catullus", "Celer", "Celsus", "Cerialis",
    "Cerinthus", "Cerrinius", "Cerularius", "Cethegus", "Charietto", "Chariovalda", "Chlodomeris", "Chrocus", "Chrysanthus", "Cicero",
    "Cicurinus", "Cilnius", "Cincius", "Cinna", "Cirtius", "Clarus", "Classicianus", "Claudianus", "Claudius", "Cleander",
    "Clementius", "Clemens", "Cleobulus", "Clodianus", "Clodius", "Clymenus", "Cocceianus", "Cocles", "Cognatius", "Columella",
    "Commodus", "Comonicus", "Concessus", "Concordinus", "Constantinus", "Consus", "Concordinus", "Cornelius", "Cornificius", "Cornutus",
    "Corvinus", "Cossutianus", "Cotta", "Crassus", "Crescens", "Crispinus", "Crispus", "Critonius", "Curtius", "Cyriacus",
    "Cyrillus", "Cyrus", "Dacianus", "Dalmatius", "Dalmaticus", "Damasus", "Darius", "Decianus", "Decimius", "Decimus",
    "Demetrius", "Dentatus", "Dentilinus", "Didius", "Dindymus", "Diocletianus", "Diogenes", "Dionysius", "Dioscorus", "Domitianus",
    "Donatianus", "Donatus", "Drusillus", "Drusus", "Dubitatius", "Ecclesius", "Edobichus"
   
};
}
