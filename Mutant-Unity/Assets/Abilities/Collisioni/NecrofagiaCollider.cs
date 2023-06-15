using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecrofagiaCollider : MonoBehaviour
{
    Enemy closestEnemy;

    //FIXME: se si potesse usare TryGetComponent direttamente in getEnemy non ci sarebbe bisogno di eseguire il controllo collisioni in ogni frame e si eviterebbero null references
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            closestEnemy = enemy;
            Debug.Log("NEMICO BRUTTO!!!!");
        }else
        {
            closestEnemy = null;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        Debug.Log("USCITO!!!!");
        closestEnemy = null;
    } 
    public Enemy getEnemy()
    {
        if(closestEnemy != null){
            if(closestEnemy.isActive())
                return closestEnemy;
        }
        return null;
    }
}
