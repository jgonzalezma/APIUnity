using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseWithForce : MonoBehaviour
{
    Rigidbody rb;
    public float thrust;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        rb.AddForce(transform.up * thrust);
        rb.useGravity = true;
    }
}
