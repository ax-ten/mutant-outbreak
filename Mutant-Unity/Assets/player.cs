using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public int HP = 0;

    bool grappling = false;
    Vector3 destinationVector;
    float force;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        if(grappling)
        {
            rb.isKinematic = false;
            Debug.Log("grapplin(playa)");
            rb.AddForce(destinationVector.normalized * force, ForceMode.Acceleration);
        }else 
            rb.isKinematic = true;
    }

    public void grapple(float force, Vector3 destinationVector)
    {
        grappling = true;
        this.force = force;
        this.destinationVector = destinationVector;

    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            Debug.Log("ARRIVATO DAL NEMICO (rampigno)");
            grappling = false;
        }
    }
}
