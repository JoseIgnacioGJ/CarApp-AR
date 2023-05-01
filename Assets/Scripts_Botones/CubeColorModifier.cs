using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Función para pintar el coche (carroceria, puertas...)
public class CubeColorModifier : MonoBehaviour
{
    //Partes del coche
    public MeshRenderer hood, door_front_L, door_front_R, Trunk, carrosserie, spoiler;

    //Los sliders para recoger la cantidad de cada color RGB
    public Slider red;
    public Slider green;
    public Slider blue;

    // Start is called before the first frame update
    public void OnEdit()
    {
        //Creamos los colores para cada parte del coche
        Color color = hood.material.color;
        Color color1 = door_front_L.material.color;
        Color color2 = door_front_R.material.color;
        Color color3 = Trunk.material.color;
        Color color4 = carrosserie.material.color;
        Color color5 = spoiler.material.color;

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

        color3.r = red.value;
        color3.g = green.value;
        color3.b = blue.value;

        color4.r = red.value;
        color4.g = green.value;
        color4.b = blue.value;

        color5.r = red.value;
        color5.g = green.value;
        color5.b = blue.value;

        //Pintamos los cristales con los colores recogidos
        hood.material.color = color;
        hood.material.SetColor("_EmissionColor", color);
        door_front_L.material.color = color1;
        door_front_L.material.SetColor("_EmissionColor", color1);
        door_front_R.material.color = color2;
        door_front_R.material.SetColor("_EmissionColor", color2);
        Trunk.material.color = color3;
        Trunk.material.SetColor("_EmissionColor", color3);
        carrosserie.material.color = color4;
        carrosserie.material.SetColor("_EmissionColor", color4);
        spoiler.material.color = color4;
        spoiler.material.SetColor("_EmissionColor", color4);
    }
}
