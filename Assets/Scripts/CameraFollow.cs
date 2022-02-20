using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform FollowTarget;
    private Vector3 _offset;
    private float _fixedY;


    private void Awake()
    {
        Vector3 InitialPosition = transform.position;
        _offset = InitialPosition - FollowTarget.position;
        _fixedY = InitialPosition.y;
    }
    
    void LateUpdate()
    {
        Vector3 newPosition = FollowTarget.position + _offset;
        newPosition.y = _fixedY;
        transform.position = newPosition;
    }
}
