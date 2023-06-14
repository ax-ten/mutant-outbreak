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
        if(collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            closeEnemy = enemy;
            Debug.Log("NEMICO BRUTTO!!!!");
        }else
        {//non mi piacciono le null reference :(
            closeEnemy = null;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        Debug.Log("USCITO!!!!");
        closeEnemy = null;
    } 



    abilityState state = abilityState.ready;
    void Update()
    {
        switch(state)
        {
            case abilityState.ready:
                if(/*TODO: tasto premuto*/ true)
                { 
                    if(closeEnemy != null)
                        if(closeEnemy.isActive())
                            ability.closestEnemy = closeEnemy;
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
