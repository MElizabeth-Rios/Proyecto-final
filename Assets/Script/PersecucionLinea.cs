//Nombre del desarrollador: María Elizabeth Rios Linderos
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo: 
/*
 Este script hara que el enemigo persiga a Player   
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersecucionLinea : MonoBehaviour
{//inicio del cuerpo de la clase 

    public Transform target;
    [SerializeField]
    Kevin playerVida;

    // Start sirve para inicializar datos, componentes y variables (lectura)
    void Start()
    {
        //el target sera el jugador siempre y causar la asignacion automatica al target 
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    // Update sirve para utilizar los datos componentes y variables 
    void Update()
    {
        //se mueve el dueño del codigo hacia la posicion de Player con una velocidad de 3 min mostrado en un tiempo de reloj 
        transform.position = Vector2.MoveTowards(transform.position,target.position,3f*Time.deltaTime);//linea recta 
    }
    
}//fin del cuerpo de la clase 
