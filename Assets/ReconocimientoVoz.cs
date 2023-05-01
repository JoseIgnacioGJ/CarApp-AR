/*using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;
using System;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;


public class ReconocimientoVoz : MonoBehaviour
{
    //DECLARAMOS UN OBJETO QUE RECONOZCA NUESTRA VOZ
    private KeywordRecognizer keywordRecognizer;

    //Color Aleatorio
    public GameObject hood, Door_front_L, Door_front_R, Trunk, Carrosserie, Spoiler;

    //Puertas
    private Animator puerta_r;
    private puerta derecha;

    //Ventanas
    private Animator ventana_r;
    private ventana derechaV;

    //DECLARAMOS UN DICCIONARIO QUE GUARDE LAS PALABRAS QUE USAREMOS JUNTO CON UNA FUNCION
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

    void Start()
    {

        actions.Add("color", ColorRandom); //ASIGNAMOS A UNA PALABRA DEL DICCIONARIO A UNA FUNCION
        actions.Add("abrir", AbrirPuerta);
        actions.Add("cerrar", CerrarPuerta);
        actions.Add("bajar", BajarVentana);
        actions.Add("subir", SubirVentana);
        actions.Add("piloto", EscenaPiloto);
        actions.Add("copiloto", EscenaCopiloto);
        actions.Add("exterior", EscenaExterior);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;

        keywordRecognizer.Start();       //INICIAMOS EL RECONOCEDOR DE VOZ

    }

    //FUNCION INTERMEDIA QUE RECONOCE LA PALABRA Y LA ASOCIA A LA FUNCION
    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    //FUNCION QUE QUEREMOS QUE REALICE AL HABLAR
    private void ColorRandom()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);

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
    }

    private void AbrirPuerta()
    {
        puerta_r = GetComponent<Animator>();
        derecha = GameObject.Find("codigo_puerta").GetComponent<puerta>();

        derecha.abrir = true;

        if (derecha.abrir)
            puerta_r.SetBool("abrir", true);;
    }

    private void CerrarPuerta()
    {
        puerta_r = GetComponent<Animator>();
        derecha = GameObject.Find("codigo_puerta").GetComponent<puerta>();

        derecha.abrir = false;

        if (!derecha.abrir)
            puerta_r.SetBool("abrir", false);
    }

    private void BajarVentana()
    {
        ventana_r = GetComponent<Animator>();
        derechaV = GameObject.Find("codigo_ventana").GetComponent<ventana>();

        derechaV.bajar = true;

        if (derechaV.bajar)
            ventana_r.SetBool("bajar", true);
    }

    private void SubirVentana()
    {
        ventana_r = GetComponent<Animator>();
        derechaV = GameObject.Find("codigo_ventana").GetComponent<ventana>();

        derechaV.bajar = false;

        if (!derechaV.bajar)
            ventana_r.SetBool("bajar", false);
    }

    private void EscenaPiloto()
    {
        SceneManager.LoadScene("escena_primeraPersona");
    }

    private void EscenaCopiloto()
    {
        SceneManager.LoadScene("escena_segundaPersona");
    }

    private void EscenaExterior()
    {
        SceneManager.LoadScene("escena_escala");
    }
}*/
