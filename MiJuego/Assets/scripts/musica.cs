using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class musica : MonoBehaviour
{
    public void Awake()
    {
        GameObject[] musica = GameObject.FindGameObjectsWithTag("Musica");
        if (musica.Length > 1) {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
