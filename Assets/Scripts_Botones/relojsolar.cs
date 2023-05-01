using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Función para colocar el sol con respecto al 
//tiempo real del ordenador.
public class relojsolar : MonoBehaviour
{
    public GameObject sol;
    public GameObject coche;

    //Radio del arco que va desde el coche hasta el sol.
    public float radio = 10;

    //ponemos este valor inicial para que cuando sea de noche, la luz esté bajo el coche
    public float angulo = -90;

    // El sol sale a las 7 am y se pone a las 7 pm
    public float tiempo_min = 7;
    public float tiempo_max = 19;

    void Start()
    {
    }

    void Update()
    {

        //Calculamos las horas, minutos y segundos del ordenador.
        float h = System.DateTime.Now.Hour,
              min = System.DateTime.Now.Minute,
              s = System.DateTime.Now.Second,

             //Transformamos ese timepo en segundos, y de las horas, eliminamos las 7 primeras
             //horas a partir de medianoche.
             t_total = 3600 * (h - tiempo_min) + 60 * min + s,
             max_total = 3600 * (tiempo_max - tiempo_min);



        //A las 7 am sale el sol, y a las 7 pm se pone.
        //Comprobamos que está en esas dos horas a partir del cálculo anterior.
        if (0 <= t_total && t_total <= max_total)
        {
            //El sol se mueve en un ángulo de 180 grados, entre los periodos de
            //tiempo 0 y 43200
            angulo = t_total * 180 / max_total;
            angulo = Mathf.PI * angulo / 180; //pasamos de grados a radianes


        }

        //Movemos el sol con respecto a la posición del coche, el radio asignado
        //y el ángulo obtenido
        sol.transform.position = coche.transform.position +
                                 new Vector3(0,
                                 radio * Mathf.Sin(angulo),
                                -radio * Mathf.Cos(angulo));

        // salida para registrar el cambio de posición
        Debug.Log(sol.transform.position);

        print("Horas " + h + " ,minutos " + min + " ,segundos " + s + "\n");
        print("Total " + t_total + " ,angulo " + angulo + "\n");
        print("X " + sol.transform.position.x + " Y " + sol.transform.position.y + " Z " + sol.transform.position.z);

    }
}
