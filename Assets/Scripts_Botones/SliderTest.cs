using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//función para crear el slider del color
public class SliderTest : MonoBehaviour
{
    public Slider sliderInstance;

    // Start is called before the first frame update
    void Start()
    {
        //valores mínimo y máximo que puede recoger los sliders
        sliderInstance.minValue = 0;
        sliderInstance.maxValue = 255;
        sliderInstance.wholeNumbers = true;
        sliderInstance.value = 100;
    }

    //mostramos el valor del slider
    public void OnValueChanged(float value)
    {
        Debug.Log("New Value " + value);
    }

}
