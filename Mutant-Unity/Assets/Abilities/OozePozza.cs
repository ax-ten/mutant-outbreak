using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OozePozza : GenericAbility
{
    //string name = "Pozza";
    //string description = "HO PISCIATO!!!💦🫠";
    GameObject pozza = null;
    EnemyCollider enemyCollision;
    Enemy closeEnemy;

    public override int Perform(GameObject parent)
    {   
        pozza = GameObject.Find("Pozza");

        enemyCollision = (EnemyCollider)pozza.gameObject.GetComponent(typeof(EnemyCollider));

        if (pozza != null)
        {
            //FIXME: spostami a livello piedi per favore 👃
            pozza.transform.position = parent.transform.position;
            pozza.SetActive(true);
            if(closeEnemy != null)
            {
                closeEnemy = enemyCollision.getEnemy();
                closeEnemy.slowDown(2, 5);
                Debug.Log("ho pisciato con successo❗️❗️❗️❗️");
            }
            else
                Debug.Log("NO NEMICI DA PISCIARE");
        }
        else Debug.Log("no piscio rilevato");
        return 0;
    }
}
