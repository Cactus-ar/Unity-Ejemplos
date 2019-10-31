using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    // Start is called before the first frame update
    public void CargarJuego()
    {
        //Va a cargar la siguiente escena configurada en las Build Settings
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

   public void Salir()
    {
        Application.Quit();
    }
}
