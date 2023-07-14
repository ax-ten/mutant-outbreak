using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 position;
    bool isLiving;
    float speed;

    public Vector3 getPosition()
    {
        return transform.position;
    }

    public bool isAlive()
    {
        return isLiving;
    }
    public bool isActive()
    {
        return gameObject.activeInHierarchy;
    }

    public void despawn(){
        Debug.Log("ded x_x");
        gameObject.SetActive(false);
        //FIXME: eliminare dalla memoria o no?
        Object.Destroy(gameObject);
        Object.Destroy(this);
    }

    public IEnumerator slowDown(float speedMultiplier, float time)
    {
        this.speed *= speedMultiplier;
        yield return new WaitForSeconds(time);
        this.speed /= speedMultiplier;
    }
    // Start is called before the first frame update
    void Start()
    {
        isLiving = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
