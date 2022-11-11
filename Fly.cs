using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    Rigidbody rb;
    public Transform target;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (target == null)
        {
            target = this.gameObject.transform;
        }
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(0, 0, 0.5f);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(0, 0, -0.5f);
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
            rb.velocity += transform.up * 0.5f;
    }
}
