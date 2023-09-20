using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarDesactivarObject : MonoBehaviour
{
    public GameObject myCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))//si pulso la P
        {
            gameObject.SetActive(false);
        } 
        else if(Input.GetKeyDown(KeyCode.O))
        {
            myCube.SetActive(!myCube.activeInHierarchy);
        }

    }
}
