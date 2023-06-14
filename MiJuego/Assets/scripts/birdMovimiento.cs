using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdMovimiento : MonoBehaviour
{
    public Transform pivot; //manipular el punto de pivote
    public float springRange; // rango en el que vamos a poder manipular nuestra ave
    public float maxVel; // la velociada maxima 

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic; //cuerpo kinematico para poder manipularlo 
    }
    bool puedeArrastrar = true;
    Vector3 dis;
    void OnMouseDrag()
    {
        if (!puedeArrastrar)
            return;
        var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dis = pos - pivot.position;
        dis.z = 0;

        if (dis.magnitude > springRange)
        {
            dis = dis.normalized * springRange;
        }
        Vector3 newPosition = dis + pivot.position;
        newPosition.z = 0; // Mantener la posición Z en 0
        transform.position = newPosition;
    }
    //cuando dejamos de arrastrar a nuesto personaje 
    void OnMouseUp()
    {
        if (!puedeArrastrar)
            return;
        puedeArrastrar = false;

        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.velocity = -dis.normalized * maxVel * dis.magnitude / springRange;
    }
}
