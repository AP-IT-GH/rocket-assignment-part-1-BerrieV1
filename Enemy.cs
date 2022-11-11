using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform player;
    float speed = 5f;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 position = Vector3.MoveTowards(transform.position, player.position, speed * Time.fixedDeltaTime);
        rb.MovePosition(position);
        transform.LookAt(player);
    }
}
