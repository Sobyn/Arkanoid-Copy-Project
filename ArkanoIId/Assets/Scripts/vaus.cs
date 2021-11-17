using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vaus : MonoBehaviour
{
    public float movementSpeed = 150;

    private void FixedUpdate() {
        float horizontal = Input.GetAxisRaw("Horizontal");     //  Get the player's horizontal input
        GetComponent<Rigidbody2D>().velocity = Vector2.right * horizontal * movementSpeed;
    }
}
