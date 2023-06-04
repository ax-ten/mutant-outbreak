using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public Transform target;
    Vector3 offset;
    public float _smoothSpeed;

    void Start() {
        transform.eulerAngles = new Vector3(20,-45,0);
        offset = transform.position - target.position;
        _smoothSpeed = 3f;
    }

    private void LateUpdate() {
        SmoothFollow();
    }

    void SmoothFollow() {
        Vector3 targetPos = target.position + offset;
        Vector3 smoothFollow = Vector3.Lerp(transform.position, targetPos, _smoothSpeed);
        transform.position = smoothFollow;
        //transform.LookAt(target);
    }
}
