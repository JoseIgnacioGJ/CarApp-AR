using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//función para activar y desactivar las cámaras, 
//según el botón del menú Vista seleccionado
public class togglecam : MonoBehaviour
{
    //cámara exterior
    public Camera AR;

    //cámara piloto
    public Camera cam1;

    //cámara co-piloto
    public Camera cam2;

    public void cambio(int n)
    {
        //activamos el piloto y desactivamos el resto
        if (n == 1)
        {
            AR.enabled = false;
            cam2.enabled = false;
            cam1.enabled = true;
        }
        else
        {
            //activamos el co-piloto y desactivamos el resto
            if (n == 2)
            {
                AR.enabled = false;
                cam1.enabled = false;
                cam2.enabled = true;
            }
            else //activamos la cámara exterior y desactivamos el resto
            {
                cam1.enabled = false;
                cam2.enabled = false;
                AR.enabled = true;
            }
        }

    }
}
