using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonePrefab : MonoBehaviour
{
    public GameObject _object;
    public Transform transformChild;
    public float thrust;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            Invoke("CreateObject", 1);
        } 
    }

    void CreateObject() 
    {
        GameObject cloneBall = Instantiate(_object, transformChild.position, transformChild.rotation);
        Rigidbody rbBall = cloneBall.GetComponent<Rigidbody>();
        Destroy(cloneBall, 7);
        rbBall.AddForce(Vector3.up * thrust);
        rbBall.AddForce(transform.forward * thrust);
    }
}
