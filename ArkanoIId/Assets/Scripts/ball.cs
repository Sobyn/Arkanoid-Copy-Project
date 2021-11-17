using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float movementSpeed = 100f;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * movementSpeed;
    }
}
