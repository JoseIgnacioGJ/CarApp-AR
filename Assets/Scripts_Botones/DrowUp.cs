using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Función que crea la animación de plegar y desplegar el menú color
public class DrowUp : MonoBehaviour
{
    //animación del menú
    private Animator buttonAnimColor;

    //botón principal para plegar y desplegar
    private Boton_Color botonColor;

    //Recogemos los datos de la animación y el botón
    void Start()
    {
        buttonAnimColor = GetComponent<Animator>();
        botonColor = GameObject.Find("codigo_color").GetComponent<Boton_Color>();
    }

    //Plegamos o desplegamos los botones secundarios del color
    void Update()
    {
        if (botonColor.showMenuColor)
            buttonAnimColor.SetBool("b_showMenuColor", true);
        if (!botonColor.showMenuColor)
            buttonAnimColor.SetBool("b_showMenuColor", false);
    }
}
