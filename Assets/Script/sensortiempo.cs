//Nombre del desarrollador: María Elizabeth Rios Linderos
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo: 
/*
 El fin que se queria con este scrip era el que los sensores se activaran y desactivaran por un determinado tiempo pero no se pudo lograr el cometido por lo que se uso animación 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensortiempo : MonoBehaviour
{//inicio de la clase 
    public GameObject demon;
    public Animation animacion;


    // Start sirve para inicializar datos, componentes y variables (lectura)
    void Start()
    {

        //InvokeRepeating("Spawn", 2,1);
        //InvokeRepeating("Spawn", 5, 1);
    }

    // Update sirve para utilizar los datos componentes y variables 
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            demon.SetActive(false);
            animacion.enabled = false;
        }
        else
        {
            demon.SetActive(true);
            animacion.enabled = true;
        }
    }

    #region Intentos
    //void Spawn()
    //{
    //    if (demon)
    //    {
    //        demon.SetActive(false);
    //    }
    //    else
    //    {
    //        demon.SetActive(true);
    //    }       
    //}
    //void ObjetoInvoke()
    //{

    //    Instantiate(demon, new Vector3(0f, 0f, 0f), Quaternion.identity);
    //}


    //public GameObject Sensor;
    //bool visor;

    //void Start()
    //{
    //    visor = Sensor;

    //    Invoke("Visor", 3f*Time.deltaTime);  
    //}
    //void Update()
    //{
    //    if (visor == false)
    //    {
    //        visor = true;
    //    }
    //    else
    //    {
    //        visor = false;
    //    }
    //}


    //public GameObject objeto;
    //void Start()
    //{
    //    objeto.gameObject.SetActive(false);
    //}
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.M))
    //    {
    //        objeto.gameObject.SetActive(true);
    //    }
    //}
    #endregion
}//fin de la clase 
