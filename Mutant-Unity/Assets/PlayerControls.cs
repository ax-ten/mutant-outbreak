using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour{
    private Rigidbody _rb;
    private InputProvider _inputProvider;
    public float turnSpeed = 860;
    public float speed = 45f;
    public float jumpForce = 3f;
    static string _myLog;

    void OnEnable(){
        _inputProvider = new InputProvider();
        _inputProvider.Enable();
    }

    void Start()    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()    {
        Walk();
        Look();
        Jump();
    }

    Vector3 GetWalkDirection(){
        return Quaternion.AngleAxis(-45, Vector3.up) * 
            new Vector3(_inputProvider.WalkDirection().x, 0, _inputProvider.WalkDirection().y);    
    }

    void Walk() {
        _rb.MovePosition(transform.position + GetWalkDirection() * (speed * Time.deltaTime) );
    }

    private void Jump() {
        if (_inputProvider.DoJump()){
            _rb.AddForce(new Vector3 (0,5,0) * jumpForce);
        }
    }

    void Look() {
        if (GetWalkDirection() != Vector3.zero){
            var Position = transform.position;
            var relative = (position + GetWalkDirection()) - position;
            var rot = Quaternion.LookRotation(relative, Vector3.up);
            var rotationalFactor = Vector3.Angle(position, relative);
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation, rot, Mathf.Pow(rotationalFactor,1)* turnSpeed*Time.deltaTime);
        }
    }
}
