using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumerosMagicos : MonoBehaviour {

    /* Básicamente Muestra en la consola de unity
     * un ejemplo de conceptos basicos como variable scope
     * un par de condicionales y llamadas a funciones
     */



    int numero_max;
    int numero_min;
    int adivina;

    // Use this for initialization
    void Start () {
        InitJuego();        
	}

    void InitJuego()
    {
        numero_max = 1000;
        numero_min = 1;
        adivina = 500;
        Debug.Log("Bienvenido a Números Mágicos");
        Debug.Log("Ingrese un Número:");
        Debug.Log("El valor más alto es: " + numero_max);
        Debug.Log("El mínimo es: " + numero_min);
        Debug.Log("Creo que el numero es.." + adivina);
        Debug.Log("Presiona Tecla Arriba si es más Alto, Tecla Abajo por más Bajo o Intro si acerté");
        numero_max++;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            numero_min = adivina;
            IntentaAdivinar();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            numero_max = adivina;
            IntentaAdivinar();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Soy una Genia!!");
            InitJuego();
        }
		
	}

    void IntentaAdivinar()
    {
        adivina = (numero_max + numero_min) / 2;
        Debug.Log("Es menos o mas que " + adivina);
    }
}
