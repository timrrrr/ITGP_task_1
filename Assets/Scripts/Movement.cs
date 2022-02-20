using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float Speed = 1f;

    public Vector3 Direction1 = Vector3.forward;
    public Vector3 Direction2 = Vector3.left;
    
    private Rigidbody _rigidbody;
    private int _directionIndex = 0;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_directionIndex == 0)
            {
                _directionIndex = 1;
                // _rigidbody.constraints = RigidbodyConstraints.FreezeRotationZ;
                // Vector3 newRotation = transform.rotation.eulerAngles;
                // newRotation.z = 0;
                // transform.rotation = Quaternion.Euler(newRotation);
            }

            else
            {
                _directionIndex = 0;
                // _rigidbody.constraints = RigidbodyConstraints.FreezeRotationX;
                // Vector3 newRotation = transform.rotation.eulerAngles;
                // newRotation.x = 0;
                // transform.rotation = Quaternion.Euler(newRotation);
            }
                
        }
    }

    private Vector3 GetDirection()
    {
        if (_directionIndex == 0)
            return Direction1;
        else
            return Direction2;
    }

    private void FixedUpdate()
    {
        Vector3 velocity = GetDirection() * Speed;
        velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = velocity;
    }
    
    private void OnDisable()
    {
        Vector3 velocity = Vector3.zero;
        velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = velocity;
    }
}
