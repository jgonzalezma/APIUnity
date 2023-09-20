using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    public int speed;
    public int turnSpeed;
    void Awake()
    {
        //Debug.Log("Awake");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start");
        float xPosition = transform.position.x;
        //Debug.Log("Posicion en X es: " +xPosition);
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento de un objeto = direccion * velocidad
        /*
        * Vector3 forward = (0,0,1)
        * Vector3.right = (1,0,0) -> Eje X
        * Vector.up = (0,1,0) -> Eje Y
        */
        
        //transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        //Debug.Log("Update: " + Time.deltaTime);
        Movement();
    }

    void FixedUpdate()
    {
        //Debug.Log("FixedUpdate: " + Time.deltaTime);
    }

    void MovementGetKey()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            Debug.Log("Acabo de pulsar la tecla W");
        }
        else if(Input.GetKey(KeyCode.S)) 
        {
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
            Debug.Log("Estoy pulsando la tecla S");
        } 
        else if(Input.GetKey(KeyCode.D)) 
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
            Debug.Log("Acabo de liberar la tecla D");
        }
        else if(Input.GetKey(KeyCode.A)) 
        {
            transform.Rotate(-Vector3.up * turnSpeed * Time.deltaTime);
            Debug.Log("Acabo de liberar la tecla A");
        }
    }

    void Movement()
    {
        float v = Input.GetAxis("Vertical"); //Mapeo teclas WS, si pulso W v = 1, si pulso S, v = -1
        //si no pulso nada, v = 0
        float h = Input.GetAxis("Horizontal"); //Mapeo teclas AD
        transform.Translate(Vector3.forward * speed * v * Time.deltaTime);
        transform.Rotate(Vector3.up * turnSpeed * h * Time.deltaTime);
    }

}
