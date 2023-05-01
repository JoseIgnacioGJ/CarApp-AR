using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Luz que contiene la variable para detectar si se ha pulsado 
//o no el boton de luces
public class luz : MonoBehaviour
{
    public bool encender;

    // Start is called before the first frame update
    public void encender_apagar()
    {

        if (!encender)
            encender = true;
        else if (encender)
            encender = false;
    }
}

