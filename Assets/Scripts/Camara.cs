using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject jugador;
    private Vector3 posicionRelativa ;

    // se ejecuta cuando el objeto entra a escena , el await siempre
    void Start()
    {
        posicionRelativa = transform.position - jugador.transform.position ;
    }

    //a diferencia del update el late se ejecuta despues 
    //de todos los componentes de la escena

    void LateUpdate()
    {
        transform.position = jugador.transform.position + posicionRelativa;
    }
}
