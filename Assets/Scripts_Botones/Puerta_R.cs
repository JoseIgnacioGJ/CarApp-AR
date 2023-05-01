using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//función para abrir y cerrar la puerta derecha
public class Puerta_R : MonoBehaviour
{
    //animación de la puerta
    private Animator puerta_r;

    private puerta derecha;

    //Recogemos los datos de la animación y la puerta
    void Start()
    {
        puerta_r = GetComponent<Animator>();
        derecha = GameObject.Find("codigo_puerta").GetComponent<puerta>();
    }

    //Aplicamos la animación en la puerta
    void Update()
    {
        if (derecha.abrir)
            puerta_r.SetBool("abrir", true);
        if (!derecha.abrir)
            puerta_r.SetBool("abrir", false);
    }
}