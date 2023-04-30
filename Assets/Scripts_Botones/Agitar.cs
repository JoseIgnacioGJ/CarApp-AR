using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Función para cambiar el color del vehículo con el agitamiento del coche
public class Agitar : MonoBehaviour
{
    //aceleración de la agitación
    Vector3 aceleracion;

    //partes del coche para cambiar el color
    public GameObject hood, Door_front_L, Door_front_R, Trunk, Carrosserie, Spoiler;
    
    //Contador de agitaciones
    int vecesAgitado = 0;
    public float timeAgitado;


    // Update is called once per frame
    void FixedUpdate()
    {
        //Nuevo color de la maqueta, elegido de forma aleatoria
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        aceleracion = Input.acceleration;

        timeAgitado += Time.deltaTime;

        //si se ha agitado lo sufientemente fuerte, aumentamos el contador
        if (aceleracion.sqrMagnitude >= 10f)
        {
            IncrementarAgitado();
        }

        //si se ha agitado lo suficiente y en breve, se cambia el color de la maqueta
        if ((vecesAgitado > 8) && (timeAgitado > 2))
        {
            var hoodRenderer = hood.GetComponent<Renderer>();
            hoodRenderer.material.SetColor("_Color", randomColor);

            var Door_front_LRenderer = Door_front_L.GetComponent<Renderer>();
            Door_front_LRenderer.material.SetColor("_Color", randomColor);

            var Door_front_RRenderer = Door_front_R.GetComponent<Renderer>();
            Door_front_RRenderer.material.SetColor("_Color", randomColor);

            var TrunkRenderer = Trunk.GetComponent<Renderer>();
            TrunkRenderer.material.SetColor("_Color", randomColor); 
            
            var CarrosserieRenderer = Carrosserie.GetComponent<Renderer>();
            CarrosserieRenderer.material.SetColor("_Color", randomColor);

            var SpoilerRenderer = Spoiler.GetComponent<Renderer>();
            SpoilerRenderer.material.SetColor("_Color", randomColor);

            // ...y reiniciamos la cantidad de veces y el tiempo
            vecesAgitado = 0;
            timeAgitado = 0;
        }
    }
    void IncrementarAgitado()
    {
        vecesAgitado += 1;
    }
}