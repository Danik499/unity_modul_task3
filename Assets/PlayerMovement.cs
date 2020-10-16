using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    static Vector3 direction;
    private Rigidbody rb;
    public bool isGrounded;
    void Start()
    {
        direction = new Vector3(0, 0, 0);
        rb = GetComponent<Rigidbody>();
}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            direction = new Vector3(1, 0, 0);
        }
        if (transform.position.x == 11)
        {
            direction = new Vector3(0, 0, 0);
        }
        transform.Translate(direction * -5 * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * 8f, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
