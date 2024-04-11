using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Captura el input horizontal (flechas izquierda/derecha)
        float verticalInput = Input.GetAxis("Vertical"); //
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized; // Calcula el movimiento

        Vector3 movement = moveDirection * speed;
        
        rb.velocity = new Vector3(movement.x,rb.velocity.y,movement.z);
    }
}
