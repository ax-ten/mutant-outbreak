using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    bool isLiving;

    public void despawn(){
        if (isLiving)
        {
            Debug.Log("ded x_x");
            gameObject.SetActive(false);
        }
    }
    public bool isAlive()
    {
        if(isLiving)
            return true;
        else 
            return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        isLiving = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
