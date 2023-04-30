using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Función que crea la animación de plegar y desplegar el menú
public class DropDown : MonoBehaviour
{
    //animación del menú
    private Animator buttonAnim;

    //botón principal para plegar y desplegar
    private Boton boton;

    //Recogemos los datos de la animación y el botón
    void Start()
    {
        buttonAnim = GetComponent<Animator>();
        boton = GameObject.Find("codigo").GetComponent<Boton>();
    }

    //Plegamos o desplegamos los botones secundarios
    void Update()
    {
        if (boton.showMenu)
            buttonAnim.SetBool("b_showMenu", true);
        if (!boton.showMenu)
            buttonAnim.SetBool("b_showMenu", false);
    }
}
