using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//función para subir y bajar la ventanilla derecha
public class Ventana_R : MonoBehaviour
{
    //animación de la ventanilla
    private Animator ventana_r;

    private ventana derechaV;

    //Recogemos los datos de la animación y la ventana    
    void Start()
    {
        ventana_r = GetComponent<Animator>();
        derechaV = GameObject.Find("codigo_ventana").GetComponent<ventana>();
    }

    //Subimos y bajamos la ventanilla
    void Update()
    {
        if (derechaV.bajar)
            ventana_r.SetBool("bajar", true);
        if (!derechaV.bajar)
            ventana_r.SetBool("bajar", false);
    }
}

