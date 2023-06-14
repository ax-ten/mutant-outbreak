using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlantRampino : GenericAbility
{
    //string name = "Necrafagia";
    //string description = "GNAMM!!! YUMMY!!! CARNE PUTRIDA DI MOSTRO!!! 😋🤤";
    int grapplingHookLenght;
    GameObject GrapplingHook;
    
    
    void Start()
    {
        
    }
    
    
    public override int Perform(GameObject parent)
    {
        GrapplingHook = parent.transform.GetChild(0).gameObject;
        return 0;
    }

}
