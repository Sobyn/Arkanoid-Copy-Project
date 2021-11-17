using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float movementSpeed = 100f;
    float hitLocation(Vector2 ballPos, Vector2 vausPos, float vausWidth){
        return(ballPos.x - vausPos.x) / vausWidth;
    }

    void Start()
        {GetComponent<Rigidbody2D>().velocity = Vector2.up * movementSpeed;}

    private void OnCollisionEnter2D(Collision2D other) {
        
        if(other.gameObject.name == "vaus"){
            float x = hitLocation(transform.position, other.transform.position, other.collider.bounds.size.x);

            Vector2 direction = new Vector2(x,1).normalized;

            GetComponent<Rigidbody2D>().velocity = direction * movementSpeed;
        }
    }
}
