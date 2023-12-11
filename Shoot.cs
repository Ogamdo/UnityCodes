
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 6000, ForceMode.Impulse);
        Destroy(gameObject, 5); // 
    }

    void Update()
    {
      
    }
}


