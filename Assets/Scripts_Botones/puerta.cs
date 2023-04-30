using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//función para abrir y cerrar la puerta
public class puerta : MonoBehaviour
{
    public bool abrir;

    //Se cambai la variable si es la primer avez o la segunda 
    //que se pulsa el boton
    public void abrir_cerrar()
    {

        if (!abrir)
            abrir = true;
        else if (abrir)
            abrir = false;
    }
}
