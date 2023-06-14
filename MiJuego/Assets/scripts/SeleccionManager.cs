using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SeleccionManager : MonoBehaviour
{
    public void BotonUno()
    {
        SceneManager.LoadScene("PaginaUno");
    }
    public void BotonDos()
    {
        SceneManager.LoadScene("PaginaDos");
    }
    public void BotonTres()
    {
        SceneManager.LoadScene("PaginaTres");
    }
    public void BotonCuatro()
    {
        SceneManager.LoadScene("PaginaCuatro");
    }
    public void BotonCinco()
    {
        SceneManager.LoadScene("PaginaCinco");
    }
    public void Botonregresar()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
    
}
