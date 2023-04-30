using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Función para mostrar el menú desplegable del color
public class Boton_Color : MonoBehaviour
{
    //comprobador de que el menú está o no desplegado
    public bool showMenuColor;

    //plegamos o desplegamos el menú
    public void ButtonShowMenuColor()
    {
        if (!showMenuColor)
            showMenuColor = true;
        else if (showMenuColor)
            showMenuColor = false;
    }
}