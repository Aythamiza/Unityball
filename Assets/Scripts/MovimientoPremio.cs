using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPremio : MonoBehaviour
{
    Vector3 rotacion = new Vector3(15, 30, 45);

    
    void Start()
    {
        
    }

   
    void Update()
    {
        // el delta time nos da los fotogramas que nos en 1 seg
        transform.Rotate(rotacion*Time.deltaTime); 
    }
}
