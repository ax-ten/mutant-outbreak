using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    private Vector3 _offset;
    public Transform target;
    public float smoothSpeed;

    void Start() {
        var transform1 = transform;
        transform1.eulerAngles = new Vector3(20,-45,0);
        _offset = transform1.position - target.position;
        smoothSpeed = 3f;
    }

    void LateUpdate() {
        SmoothFollow();
    }

    void SmoothFollow() {
        var targetPos = target.position + _offset;
        var smoothFollow = Vector3.Lerp(transform.position, targetPos, smoothSpeed);
        transform.position = smoothFollow;
        //transform.LookAt(target);
    }
}
