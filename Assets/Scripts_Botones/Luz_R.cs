using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//función para aplicar animación en la 
//luz derecha para encender o apagar
public class Luz_R : MonoBehaviour
{
    //animación que se aplica en los focos del coche
    private Animator luz_r;

    //luz del vehículo
    private luz derecha;

    //Recogemos los datos de la animación y la luz
    void Start()
    {
        luz_r = GetComponent<Animator>();
        derecha = GameObject.Find("codigo_luz").GetComponent<luz>();
    }

    //Aplicamos la animación según si está o no encendida
    void Update()
    {
        if (derecha.encender)
            luz_r.SetBool("encender", true);
        if (!derecha.encender)
            luz_r.SetBool("encender", false);
    }
}
