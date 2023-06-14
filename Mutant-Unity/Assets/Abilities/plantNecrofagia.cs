using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlantNecrofagia : GenericAbility
{
    //string name = "Necrafagia";
    //string description = "GNAMM!!! YUMMY!!! CARNE PUTRIDA DI MOSTRO!!! 😋🤤";


    public override int Perform(GameObject parent)
    {
        if(closestEnemy != null)
        {
            if(closestEnemy.isAlive())
            {
                closestEnemy.despawn();
                parent.GetComponent<Player>().HP = 10;
                return 0;
            }
        }
        else
        {
            Debug.Log("Nessun nemico vicino");
            return 1; 
        }
        return 0;
    }
}
