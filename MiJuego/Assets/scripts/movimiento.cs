using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{

    public Transform pivot;
    public GameObject birdPrefab;
    public float springRange;
    public float maxVel;

    private Rigidbody2D rb;
    private bool puedeArrastrar = true;
    private Vector3 dis;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

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
        newPosition.z = 0;
        transform.position = newPosition;
    }

    void OnMouseUp()
    {
        if (!puedeArrastrar)
            return;

        puedeArrastrar = false;

        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.velocity = -dis.normalized * maxVel * dis.magnitude / springRange;

        // Generar un nuevo pájaro en la resortera
        GameObject newBird = Instantiate(birdPrefab, pivot.position, Quaternion.identity);
        // Ajustar la posición Z del nuevo pájaro a 0
        newBird.transform.position = new Vector3(newBird.transform.position.x, newBird.transform.position.y, 0);
        // Asegurarse de que el nuevo pájaro no sea arrastrable
        newBird.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        newBird.GetComponent<movimiento>().puedeArrastrar = false;
    }





}
