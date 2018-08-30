using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JuegoAventura : MonoBehaviour {

    // Use this for initialization

    [SerializeField] Text componenteTexto;

	void Start () {
        componenteTexto.text = ("Aquí va el texto de la historia");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
