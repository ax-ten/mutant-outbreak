using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    Enemy collidingEnemy;

    
    private void OnTriggerStay(Collider collision)
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
        return collidingEnemy;
    }
}
