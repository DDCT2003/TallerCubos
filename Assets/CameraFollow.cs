using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target; // El transform del jugador
    public float smoothSpeed = 0.125f; // Velocidad de suavizado
    public Vector3 offset;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset; // Posici�n deseada de la c�mara igual a la del jugador
            desiredPosition.y = transform.position.y;

            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Interpolaci�n suave
            transform.position = smoothedPosition; // Actualizar la posici�n de la c�mara
        }
    }

}
