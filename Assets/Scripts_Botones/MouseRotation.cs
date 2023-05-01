//Pablo Laborde-Bois, Jorge Blasco, Jose Ignacio Garcia

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//función para rotar y escalar la maqueta
public class MouseRotation : MonoBehaviour
{
    private Touch touch, touch2;                   //DECLARAMOS LOS TOUCH, UNO PARA CADA DEDO
    private Quaternion rotationY;                 //DECLARAMOS UNA VARIABLE DE TIPO CUATERNION PARA APLICAR LA ROTACION
    private float rotateSpeed = 0.4f;            //VELOCIDAD CON LA QUE GIRA CADA VEZ QUE DESLIZAMOS EL DEDO
    private float distancia, distanciaAnterior = -1; //DISTANCIAS ENTRE LOS DOS VECTORES DE CADA DEDO

    // Update is called once per frame
    void Update()
    {
            //SI PULSAMOS LA PANTALLA CON UN DEDO 
            //APLICAMOS ROTACION
            if (Input.touchCount == 1)
            {
                touch = Input.GetTouch(0);   //NUESTRA VARIABLE TOUCH COINCIDE CON EL PRIMER TOUCH QUE DETECTA LA PANTALLA

                if (!EventSystem.current.IsPointerOverGameObject(touch.fingerId))
                {

                    //DETECTA COMO SE MUEVE EL DEDO EN EL EJE X PARA SABER EN QUE SENTIDO GIRAR
                    if (touch.phase == TouchPhase.Moved)
                    {
                        rotationY = Quaternion.Euler(0f, -touch.deltaPosition.x * rotateSpeed, 0f);
                        transform.rotation = rotationY * transform.rotation;   //APLICAMOS LA ROTACION ANTERIOR COMO UNA TRANSFORMACION AL OBJETO
                    }
                }
            }

            //SI PULSAMOS LA PANTALLA CON DOS DEDOS
            //APLICAMOS ESCALADO
            else if (Input.touchCount == 2)
            {
                float x = 0.1f;
                float y = 0.1f;
                float z = 0.1f;

                touch = Input.GetTouch(0);  //NUESTRA VARIABLE TOUCH COINCIDE CON EL PRIMER TOUCH QUE DETECTA LA PANTALLA
                touch2 = Input.GetTouch(1); //NUESTRA VARIABLE TOUCH2 COINCIDE CON EL SEGUNDO TOUCH QUE DETECTA LA PANTALLA

                distancia = (touch.position - touch2.position).magnitude;   //DISTANCIA ENTRE  LOS DOS VECTORES

                if (distanciaAnterior > 0)
                {

                    float relDist = distancia / distanciaAnterior;
                    Vector3 currentScale = transform.localScale;
                    currentScale *= relDist;

                    // COMPROBAR UN TAMAÑO MINIMO
                    //if (currentScale.x < 0.1)
                    //  currentScale = Vector3.one;

                    transform.localScale = currentScale;
                }

                distanciaAnterior = distancia;
            }
            else
            {
                distanciaAnterior = -1;
            }
    }
}
