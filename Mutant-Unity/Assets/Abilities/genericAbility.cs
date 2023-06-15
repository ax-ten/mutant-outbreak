using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class GenericAbility : ScriptableObject
{
    //NOME e DESCRIZIONE abilità
    //string name, description;
    //RARITÀ: 0 = iniziale, 1 = bassa, 2 = media, 3 = alta
    int rarity;
    //COOLDOWN e DURATA
    public float cooldownTime, activeTime;    
    //TIPO: 0 plantoide, 1 minerale, 2 melma
    int type;
    //RANGE di azione
    float range;
    //se genera ulteriori effetti grafici
    bool hasVisuals;
    GenericAbility upgradeBasic, upgradeAdvanced;

    
    public abstract int Perform(GameObject parent);

}
