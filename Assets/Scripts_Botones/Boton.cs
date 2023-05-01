using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Función para mostrar el menú desplegable
public class Boton : MonoBehaviour
{
    //comprobador de que el menú está o no desplegado
    public bool showMenu;

    //Cambio de variable. Detecta si se ha pulsado una vez(true)
    //o es la segunda (false)
    public void ButtonShowMenu()
    {
        if (!showMenu)
            showMenu = true;
        else if (showMenu)
            showMenu = false;
    }
}
