//Nombre del desarrollador: María Elizabeth Rios Linderos
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo: 
/*
 Este script hara la funcion para que Player pueda cambiar de escena/nivel 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;//esta libreria ayuda a que se cambie de escena 
using UnityEngine;


public class cambioEscena : MonoBehaviour
{//inicio del cuerpo de la clase 
  
    [Tooltip("Esta variable me ayuda a definir el número de escena a cargar")]//como se menciona entre comillas este tipo de variable ayuda a definir el número de las escenas
    public int numeroEscena;

    //Trigger es una forma en la que se puede pasar sobre el objeto 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //al colicionar con el objeto trigger indicado Player cambiara de escena 
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(numeroEscena);
        }
        
    }

}//fin del cuerpo de la clase 
