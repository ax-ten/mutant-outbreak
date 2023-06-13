using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityHolder : MonoBehaviour
{
    public GenericAbility ability;
    float cooldownTime;
    float activeTime; 
    Enemy closeEnemy;

    enum abilityState
    {
        ready,
        active,
        cooldown
    }


    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("RILEVATOOO!!!!");
        if(collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            closeEnemy = enemy;
            Debug.Log("NEMICO BRUTTO!!!!");
        }else
        {//non mi piacciono le null reference :(
            closeEnemy = null;
        }
    }//FIXME: dovrebbe aiutare le null reference ma potrebbero esserci race conditions rare 
    /*se viene fatto l'accesso a closeEnemy mentre il nemico è despawnato/disabilitato allora ci ptrebbe essere un use-after-free.*/
    private void OnTriggerExit(Collider collision)
    {
        Debug.Log("USCITO!!!!");
        closeEnemy = null;
    } 

    abilityState state = abilityState.ready;
    void Update()
    {
        if(closeEnemy != null)
            ability.closestEnemy = closeEnemy;
        switch(state)
        {
            case abilityState.ready:
                if(/*TODO: tasto premuto*/ true)
                { 
                    ability.Perform(gameObject); 
                    state = abilityState.active;
                    activeTime = ability.activeTime;
                }
                break;
            case abilityState.active:
                if (activeTime > 0)
                {
                    activeTime -= Time.deltaTime;
                } else
                {
                    state = abilityState.cooldown;
                    cooldownTime = ability.cooldownTime;
                }
                break;
            case abilityState.cooldown:
                if (cooldownTime > 0)
                {
                    cooldownTime -= Time.deltaTime;
                } else 
                {state = abilityState.ready;}
                break;
        }
    }
}
