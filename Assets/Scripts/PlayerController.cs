using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject proyectil;
    private Quaternion right = Quaternion.Euler(0, 90, 0);
    private Quaternion left = Quaternion.Euler(0, -90, 0);
    private Quaternion up = Quaternion.Euler(-90, 0, 0);
    private Quaternion down = Quaternion.Euler(90, 0, 0);
    

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            SpawnProjectile(right);
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SpawnProjectile(left);
        }
       
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            SpawnProjectile(up);
        }
        
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            SpawnProjectile(down);
        }

       

    }

    public void SpawnProjectile(Quaternion rotation)
    {
        Instantiate(proyectil, transform.position, rotation);
    }

   
} 
