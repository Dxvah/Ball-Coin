using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{

    public float m_Speed = 10f;
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;


    
    void Start()
    {
        
    }

   
    void Update()
    {
        movimientoEjeX = - Input.GetAxis("Horizontal") * Time.deltaTime;
        movimientoEjeZ = - Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(movimientoEjeX * m_Speed, movimientoEjeY, movimientoEjeZ * m_Speed);
    }
}
