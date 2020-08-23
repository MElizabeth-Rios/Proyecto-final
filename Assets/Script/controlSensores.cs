//Nombre del desarrollador: María Elizabeth Rios Linderos
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo: 
/*
 Este script se utilizara para el control general de todos los sensores/visores que aparescan en escena  
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlSensores : MonoBehaviour
{//inicio del cuerpo de la clase

    public static int numSensores;//cantidad de sensores que existiran dentro de escena 

    public GameObject objeto_Sensor;//Objeto que se usara 
    public Transform[] spawnPoint;//de donde se creara el objeto 
   

    public int infoCantidadSensores;//esta podra ser visual en inspector sabre cuantos sensores habra en la pantalla

    // Start sirve para inicializar datos, componentes y variables (lectura)
    void Start()
    {
        numSensores = 0;
        spawnPoint = new Transform[transform.childCount];//en esta parte se esta nombrando a spawPoin como hijo de controlSensores 
        for (int i = 0; i < spawnPoint.Length; i++)
        {
            spawnPoint[i] = transform.GetChild(i);//se asigna a cada indice a cada spawPoint de los hijos que se encuentren vinculada a este objeto 
        }

        Invoke("Spawn", 2);//se crean los sensores en un tiempo de 2 segundo despues de darle Play 

    }

    // Update sirve para utilizar los datos componentes y variables 
    void Update()
    {
        infoCantidadSensores = numSensores;//aqui ambas variables estaran vinculadas entre si ya que una si se muestra en el inspector y la otra no
        
    }
    void Spawn()
    {
        foreach (var p in spawnPoint)//lectura de manera ordenada de todos los sensores que lleguen a parecer dentro de la pantalla por parte de spawPOINT 
        {
            GameObject SensorPos = Instantiate(objeto_Sensor) as GameObject;
            SensorPos.transform.position = p.position;//en esta parte el sensor se creara en la posicion donde estara el spawPoint 
            if (numSensores >= 5)
            {
                Destroy(SensorPos);
            }
        }

    }

}//fin del cuerpo de la clase 
