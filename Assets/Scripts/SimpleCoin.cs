using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class SimpleCoin : MonoBehaviour
{
    //public GameObject score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            ScoreManager.instance.AddPoint();
        }
    }
}
