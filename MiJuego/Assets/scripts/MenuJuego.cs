using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuJuego : MonoBehaviour
{
    public void BotonMenuJuego(string escena)
    {
        SceneManager.LoadScene(escena);
    }
    public void BotonRegresarSeleccion()
    {
        SceneManager.LoadScene("Seleccion");
    }
}
