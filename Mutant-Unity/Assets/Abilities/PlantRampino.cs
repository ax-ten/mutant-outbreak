using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlantRampino : GenericAbility
{
    //string name = "Necrafagia";
    //string description = "GNAMM!!! YUMMY!!! CARNE PUTRIDA DI MOSTRO!!! 😋🤤";
    Vector3 departureVector, destinationVector, enemyVector;
    public float force = 100.0f;
    EnemyCollider enemyCollision;
    Enemy closeEnemy;
    Rigidbody rb;

    public override int Perform(GameObject parent)
    {
        enemyCollision = (EnemyCollider) parent.transform.GetChild(1).gameObject.GetComponent(typeof(EnemyCollider));
        closeEnemy = enemyCollision.getEnemy();

        Player a = (Player) parent.gameObject.GetComponent(typeof(Player));
        

        departureVector = parent.transform.position;
        enemyVector = closeEnemy.gameObject.transform.position;
        destinationVector = enemyVector - departureVector + new Vector3(2,2,2);

        if(closeEnemy != null)
        {
            Debug.Log("rampinandomi");
            Debug.Log(destinationVector);
            a.grapple(force, destinationVector);
        }else {
            Debug.Log("Nessun nemico (rampino))");
            return 1;
        }
        return 0;
    }
}
