//Nombre del desarrollador: María Elizabeth Rios Linderos
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo: 
/*
 Este script hara la funcion de que la camara siga a Player durante el juego 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguimientoCam : MonoBehaviour
{//inicio  del cuerpo de la clase 
    public Transform target;
    public Vector3 puntoInicial;
    // Start sirve para inicializar datos, componentes y variables (lectura)
    void Start()
    {
        puntoInicial = transform.position;
    }

    // Update sirve para utilizar los datos componentes y variables 
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x,0.06f,10.25f) , Mathf.Clamp (target.position.y,0.06f,4.0f) , transform.position.z);
        //transform.position = target.position + puntoInicial;
    }
}//fin del cuerpo de la clase 
