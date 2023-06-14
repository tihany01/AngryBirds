using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumen : MonoBehaviour
{
    public Slider slider; // El control deslizador en la interfaz de usuario que permite al usuario ajustar el volumen
    public float sliderValue; // El valor actual del deslizador
    public Image imagenMute; // La imagen que se muestra cuando el volumen está silenciado
    // Start is called before the first frame update
    void Start()
    {
        // Se establece el valor inicial del deslizador al valor guardado en las preferencias del jugador, o a 0.5 si no se ha guardado ningún valor
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        // Se establece el volumen de todos los sonidos en el juego al valor del deslizador
        AudioListener.volume = slider.value;
        // Se llama a la función para verificar si el volumen está silenciado y actualizar la imagen correspondiente
        RevisarSiEstoyMute();
    }

    public void ChangeSlider(float valor)
    {
        // Esta función es llamada cuando el usuario cambia el valor del deslizador
        // Se actualiza valorDeslizador al valor actual del deslizador
        sliderValue = valor;
        // Se guarda el valor actual del deslizador en las preferencias del jugador para que se pueda recordar la próxima vez que se inicie el juego
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        // Se establece el volumen de todos los sonidos en el juego al valor del deslizador
        AudioListener.volume = slider.value;
        RevisarSiEstoyMute();
    }
    // Esta función verifica si el volumen está silenciado y activa o desactiva la imagen de silencio en consecuencia
    private void RevisarSiEstoyMute()
    {    // Si el valor del deslizador es 0 (lo que significa que el volumen está silenciado)
        if (sliderValue == 0)
        {
            imagenMute.enabled = true;
        }
        else
        {
            imagenMute.enabled = false;
        }

    }
}