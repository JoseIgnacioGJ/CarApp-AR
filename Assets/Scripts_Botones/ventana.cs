using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//función para subir y bajar la ventanillas
public class ventana: MonoBehaviour
{
    public bool bajar;

    //se comprueba si está o no bajada la ventanilla
    public void bajar_subir()
    {

        if (!bajar)
            bajar = true;
        else if (bajar)
            bajar = false;
    }
}
