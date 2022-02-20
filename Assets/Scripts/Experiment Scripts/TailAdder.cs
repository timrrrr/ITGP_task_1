using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailAdder : MonoBehaviour
{
    public GameObject TailPrefab;
    
    void Update()
    {
        Instantiate(TailPrefab, transform.position, Quaternion.identity);
    }
}
