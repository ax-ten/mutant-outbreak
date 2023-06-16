using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlantRampino : GenericAbility
{
    //string name = "Necrafagia";
    //string description = "GNAMM!!! YUMMY!!! CARNE PUTRIDA DI MOSTRO!!! 😋🤤";
    public override int Perform(GameObject parent)
    {
        //FIXME: decidere se usare un indice o cercare per nome
        EnemyCollider enemyCollision = (EnemyCollider) parent.transform.GetChild(1).gameObject.GetComponent(typeof(EnemyCollider));
        Enemy closeEnemy = enemyCollision.getEnemy();


        if(closeEnemy != null)
        {
            if(closeEnemy.isAlive())
            {
                parent.transform.LookAt(closeEnemy.transform);
                return 0;
            }
        }
        Debug.Log("Nessun nemico vicino");
        return 1;
    }
}
