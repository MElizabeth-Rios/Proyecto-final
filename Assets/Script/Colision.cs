//Nombre del desarrollador: María Elizabeth Rios Linderos
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo: 
/*
 Este script simulara la destruccion del demonio al ser colisionado por el proyectil 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{//inicio del cuerpo de la clase 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="enemy")//al colisionar con el objeto enemyeste se destruira 
        {
            Destroy(collision.gameObject);
        }

    }

}//fin del cuerpo de la clase 

