using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void BotonStart()
    {
        SceneManager.LoadScene("Seleccion");
    }

    public void BotonQuitar()
    {
        Debug.Log("Quitamos la aplicación");
        Application.Quit();
    }
}
