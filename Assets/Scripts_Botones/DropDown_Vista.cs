using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Función que crea la animación de plegar y desplegar el menú vista
public class DropDown_Vista : MonoBehaviour
{
    //animación del menú
    private Animator buttonAnimVista;

    //botón principal para plegar y desplegar
    private Boton_Vista botonVista;

    //Recogemos los datos de la animación y el botón
    void Start()
    {
        buttonAnimVista = GetComponent<Animator>();
        botonVista = GameObject.Find("codigo_vista").GetComponent<Boton_Vista>();
    }

    //Plegamos o desplegamos los botones secundarios de la vista
    void Update()
    {
        if (botonVista.showMenuVista)
            buttonAnimVista.SetBool("b_showMenuVista", true);
        if (!botonVista.showMenuVista)
            buttonAnimVista.SetBool("b_showMenuVista", false);
    }
}
