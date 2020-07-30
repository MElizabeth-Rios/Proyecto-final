//Nombre del desarrollador: María Elizabeth Rios Linderos
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo: 
/*
 Este script se utilizara para generar el control del avatar jugador 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kevin : MonoBehaviour
{// inicio del cuerpo de la clase
    Rigidbody2D movimientos2D;
    public int vida;
    public float saltoPersonaje;
    [SerializeField]
    float velocidad;
    public SpriteRenderer spriteKevin;
    // Start is called before the first frame update
    void Start()
    {
        movimientos2D = GetComponent<Rigidbody2D>();
        spriteKevin = GetComponent<SpriteRenderer>();
        saltoPersonaje = 5.0f;
        velocidad = 3.0f;
        vida = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movimientos2D.AddForce(Vector2.up * saltoPersonaje, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            movimientos2D.velocity = new Vector2(velocidad, movimientos2D.velocity.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movimientos2D.velocity = new Vector2(-velocidad, movimientos2D.velocity.y);
        }
        if (vida<=0)
        {
            spriteKevin.enabled = false;
        }
    }
}// fin del cuerpo de la clase
