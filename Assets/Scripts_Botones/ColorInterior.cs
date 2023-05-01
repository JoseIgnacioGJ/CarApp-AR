using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Función para pintar los cristales
public class ColorInterior : MonoBehaviour
{
    //Los cristales del vehículo
    public MeshRenderer elements, glass_front_L, glass_front_R;

    //Los sliders para recoger la cantidad de cada color RGB
    public Slider red;
    public Slider green;
    public Slider blue;

    // Start is called before the first frame update
    public void OnEdit()
    {
        //Creamos los colores para cada parte del coche
        Color color = elements.material.color;
        Color color1 = glass_front_L.material.color;
        Color color2 = glass_front_R.material.color;

        //Recogemos los valores de cada color RGB de cada parte del coche
        color.r = red.value;
        color.g = green.value;
        color.b = blue.value;

        color1.r = red.value;
        color1.g = green.value;
        color1.b = blue.value;

        color2.r = red.value;
        color2.g = green.value;
        color2.b = blue.value;

        //Pintamos los cristales con los colores recogidos
        elements.material.color = color;
        elements.material.SetColor("_EmissionColor", color);
        glass_front_L.material.color = color1;
        glass_front_L.material.SetColor("_EmissionColor", color1);
        glass_front_R.material.color = color2;
        glass_front_R.material.SetColor("_EmissionColor", color2);
    }
}

