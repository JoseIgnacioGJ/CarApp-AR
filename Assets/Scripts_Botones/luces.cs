using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//función para encender o apagar las luces
public class luces : MonoBehaviour
{

    //todas las luces del coche
    public Light[] lights;

    public void CambioLuz(int n)
    {
        //recorremos cada luz
        foreach (Light light in lights)
        {
            if (n == 1)
            {
                //encendemos o apagamos cada luz
                light.enabled = !light.enabled;
            }
        }
    }
}
