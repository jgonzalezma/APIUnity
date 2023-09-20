using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarDesactivarLight : MonoBehaviour
{
    public GameObject myLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Light();
    }

    void Light()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            myLight.SetActive(!myLight.activeInHierarchy);
        }
    }
}
