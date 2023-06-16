using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    Enemy collidingEnemy;

    //FIXME: se si potesse usare TryGetComponent direttamente in getEnemy non ci sarebbe bisogno di eseguire il controllo collisioni inutilmente e si eviterebbero null references
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            collidingEnemy = enemy;
            Debug.Log("NEMICO BRUTTO!!!!");
        }else
        {
            collidingEnemy = null;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        Debug.Log("USCITO!!!!");
        collidingEnemy = null;
    } 
    public Enemy getEnemy()
    {
        if(collidingEnemy != null){
            if(collidingEnemy.isActive())
                return collidingEnemy;
        }
        return null;
    }
}
