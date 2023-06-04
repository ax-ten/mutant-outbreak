using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour{
    private Rigidbody rb;
    private InputProvider inputProvider;
    public float _turnSpeed = 3600;
    public float _speed = 45f;
    public float _jumpForce = 3f;
    static string myLog;

    void OnEnable(){
        inputProvider = new InputProvider();
        inputProvider.Enable();
    }

    void Start()    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()    {
        Walk();
        Look();
        Jump();
    }

    Vector3 getWalkDirection(){
        return Quaternion.AngleAxis(-45, Vector3.up) * 
            new Vector3(inputProvider.WalkDirection().x, 0, inputProvider.WalkDirection().y);    
    }

    void Walk() {
        rb.MovePosition(transform.position + getWalkDirection() * _speed * Time.deltaTime );
    }

    void Jump() {
        if (inputProvider.doJump()){
            rb.AddForce(new Vector3 (0,5,0) * _jumpForce);
        }
    }

    void Look() {
        if (getWalkDirection() != Vector3.zero){
            var relative = (transform.position + getWalkDirection()) - transform.position;
            var rot = Quaternion.LookRotation(relative, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, _turnSpeed*Time.deltaTime);
        }
    }
}
