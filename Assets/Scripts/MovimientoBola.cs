using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoBola : MonoBehaviour
{
    Rigidbody riBo;
    public Text puntuacion;
    public float velocidad;
    int contador;
   

    private void Awake()
    {
       
        riBo = GetComponent<Rigidbody>();
        contador = 0;
        puntuacion.text = "Puntuacion: " + contador;

    }

    public void FixedUpdate()
    {
        float movimientoHori = Input.GetAxis("Horizontal");
        float movimientoVert = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHori, 0, movimientoVert);

        riBo.AddForce(movimiento * velocidad);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "premio")
        {
            Destroy(other.gameObject);
            contador = contador + 1;
            puntuacion.text = "Puntuacion: " + contador;
            GetComponent<MovimientoBola>().velocidad += 0.5f;
        }

        
        
    }


}
