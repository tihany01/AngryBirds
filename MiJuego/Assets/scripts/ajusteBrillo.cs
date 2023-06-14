using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ajusteBrillo : MonoBehaviour
{
    public void Awake()
    {
        GameObject[] brillo = GameObject.FindGameObjectsWithTag("BrilloPanel");
        if (brillo.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
