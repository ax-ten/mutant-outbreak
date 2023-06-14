using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    bool isLiving;

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
        isLiving = false;
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
