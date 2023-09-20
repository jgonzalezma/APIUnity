using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeckoMovement : MonoBehaviour
{
    public int speed, turnSpeed;

    public GameManager gameManagerScript;

    float h, v;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       InputPlayer();
       MovementPlayer();
    }

    void InputPlayer()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }

    void MovementPlayer()
    {
        transform.Translate(Vector3.forward * v * speed * Time.deltaTime); 
        transform.Rotate(Vector3.up * h * turnSpeed * Time.deltaTime); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            //acceder al GameManager para llamar a la funcion AddCoin
            gameManagerScript.AddCoin();
            Destroy(other.gameObject);
        }
    }

}
