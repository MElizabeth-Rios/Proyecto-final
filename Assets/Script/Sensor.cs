//Nombre del desarrollador: María Elizabeth Rios Linderos
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo: 
/*
 Este script funcionará para similar la destrucción de un objeto al ser colisionado por otro  
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{//inicio del cuerpo de la clase
    [SerializeField]
    Kevin vidaKevin;
    // Start is called before the first frame update
    void Start()
    {
        vidaKevin = GameObject.FindGameObjectWithTag("Player").GetComponent<Kevin>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("Hola");
            vidaKevin.vida--;
        }
    }
    
}//fin del cuerpo de la clase 
