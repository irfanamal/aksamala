using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    public TouchPad touchPad;
    public float speed;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector2 direction = touchPad.GetDirection();
        Vector3 movement = new Vector3(direction.x, 0.0f, direction.y);
        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);
        }
        rb.velocity = movement * speed;   
    }
}