using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//función para mover al usuario dentro del asiento 
//del piloto y girar el volante del coche
public class GiroscopioCamaras : MonoBehaviour
{
    //cámara del piloto
    public Camera cam1;

    public GameObject volante;

    //cuaternión que indica como este girado el volante al principio
    public Quaternion comienzo;
    public float angulo = 0;

    void Start()
    {
        Input.gyro.enabled = true; //Habilitar el giroscopio

        //cogemos la rotación inicial del volante
        comienzo = volante.transform.localRotation;
    }

    void Update()
    {
        //Si el usuario es el piloto
        if (cam1.enabled)
        {
            Quaternion q = Input.gyro.attitude;

            //rotamos la cámara y el volante
            cam1.transform.rotation = Quaternion.Euler(90, 0, 0) * new Quaternion(-q.x, -q.y, q.z, q.w);
            volante.transform.localRotation = comienzo * new Quaternion(0, -Input.gyro.attitude.y, 0, -Input.gyro.attitude.w);
        }
    }
}
