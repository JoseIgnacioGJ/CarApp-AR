using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Función para mostrar el menú desplegable de la vista
public class Boton_Vista : MonoBehaviour
{
    //comprobador de que el menú está o no desplegado
    public bool showMenuVista;

    //plegamos o desplegamos el menú
    public void ButtonShowMenuVista()
    {
        if (!showMenuVista)
            showMenuVista = true;
        else if (showMenuVista)
            showMenuVista = false;
    }
}
