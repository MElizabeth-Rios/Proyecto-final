//Nombre del desarrollador: María Elizabeth Rios Linderos
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo: 
/*
 Este scrip se vera el disparo que podra hacer Player desde mano 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Disparo : MonoBehaviour
{//inicio del cuerpo de la clase 

    [SerializeField] Rigidbody2D[] proyectil;//referencia al objeto que se disparara
    [SerializeField] int tipoMunicion = 1;
    [SerializeField] Transform mano;// referencia a de donde va a salir el proyectil 
    [SerializeField] float fuerzaDisparo;//referencia a la fuerza con el que el proyectil va

    // Start sirve para inicializar datos, componentes y variables (lectura)
    private void Start()
    {

    }

    // Update sirve para utilizar los datos componentes y variables 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            //se esta almacenando el proyectil que se creo
            var proyectilPos = Instantiate(proyectil[tipoMunicion]) as Rigidbody2D;
            //se indica donde es creado el proyectil en el espacio, en este caso seria mano 
            proyectilPos.transform.position = mano.position;

            //Se le agrega una fuerza al proyectil, saliendo en linea recta 
            proyectilPos.AddForce(mano.right * fuerzaDisparo);

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {//al chocar con el enemigo este se destruira 
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}//fin del cuerpo de la clase 

