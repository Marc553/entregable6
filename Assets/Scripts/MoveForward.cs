using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float Speed = 20; //velocidad del projetil 
    private float limitRange = 40; //numero del limite de la pantalla 

    void Update()
    {
        //Da la orden al projectil de moverse todo el rato (hacia eje Z ya que es el alante del GameObject)

        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        //Limite de pantalla X 
        if (transform.position.x > limitRange)
        {
            Destroy(gameObject);
        }
        
        if (transform.position.x < -limitRange)
        {
            Destroy(gameObject);
        }
        
        //Limite de pantalla Y
        if (transform.position.y > limitRange)
        {
            Destroy(gameObject);
        }
       
        if (transform.position.y < -limitRange)
        {
            Destroy(gameObject);
        }
    }
}
