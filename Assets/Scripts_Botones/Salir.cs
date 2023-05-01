using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//función que se aplica en el botón Salir para cerrar 
//la aplicación completamente
public class Salir : MonoBehaviour
{
    public void SaliR()
    {
        Application.Quit();
        Debug.Log("Se ha salido de la aplicacion");
    }
}
