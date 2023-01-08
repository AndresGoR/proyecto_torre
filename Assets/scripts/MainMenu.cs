using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{





    public void EscenaJuego()
    {
        SceneManager.LoadScene("Juego");
        Time.timeScale = 1f;
       if( Time.timeScale == 0f)
        {
            Debug.Log("PAUSADO");
            Time.timeScale = 1f;
        }
        else
        {
            Debug.Log("NO PAUSADO");
        }
    }



    public void EscenaOpciones()
    {
        SceneManager.LoadScene("Opciones");
        Time.timeScale = 1f;
    }

    public void VolverMenu()
    {

        Destroy(GameObject.FindWithTag("opciones"));
        Time.timeScale = 1f;

        SceneManager.LoadScene("MainMenu");

    }

    public void Salir()
    {
        Application.Quit();
    }

}
