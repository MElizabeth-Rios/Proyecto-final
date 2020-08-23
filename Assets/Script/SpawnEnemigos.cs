//Nombre del desarrollador: María Elizabeth Rios Linderos
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo: 
/*
 Este script controlara los spawPoint en donde se originaran los enemigos/demonios 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{//inicio del cuerpo de la clase
    public Transform[] puntoOrigen;//puntos spawn 
    public GameObject enemigo;//a quien se pondra como enemigo 
    public static int contadorEnemigos;//cuantos enemigos serán 
    public int contarCantidad_Enemigos;

    // Start sirve para inicializar datos, componentes y variables (lectura)
    void Start()
    {

        puntoOrigen = new Transform[transform.childCount];//el punto orijen ahora se convierte en el hijo de Spawn Enemigos 
        for (int i = 0; i < puntoOrigen.Length; i++)
        {
            puntoOrigen[i] = transform.GetChild(i);
        }

        foreach (var p in puntoOrigen)
        {
            contadorEnemigos = 0;
            for (int i = 0; i < 1; i++)
            {
                GameObject posEnemigo = Instantiate(enemigo, p.position, p.rotation);
                Vector3 posplusEnemigo = new Vector3(0, 0, i + 1);
                posEnemigo.transform.position += posplusEnemigo;
            }
        }

        contarCantidad_Enemigos = GameObject.FindGameObjectsWithTag("enemy").Length;

        

    }

    //como solo sera una accion de lectura que se hara para ejecutar las posiciones y aparicion de los enemigos 
    // Update sirve para utilizar los datos componentes y variables 
    void Update()
    {

    }
}//fin del cuerpo de la clase 
