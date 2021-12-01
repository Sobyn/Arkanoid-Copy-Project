using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float ballSpeed = 100f;
    public AudioSource hitSound;
    public GameObject playerObject;
    private Vector2 ballPosition;

    //  Below, we retrieve the ball's position relative to the 
    //  platform by dividing the ball's position with the player's width
        // ascii art example:
    //
    // -1  -0.5  0  0.5   1  <- x value
    // ====================  <- platform
    //

    float hitLocation(Vector2 ballPos, Vector2 vausPos, float vausWidth){
        //  (Return ballpos.x - vausPos.x to get the relative position)
        return(ballPos.x - vausPos.x) / vausWidth;}

    void Start(){
        GetComponent<Rigidbody2D>().velocity = Vector2.up * ballSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Block"){
            hitSound.Play();            
        }

        //  When the ball hits the platform:
        if(other.gameObject.name == "vaus")
            //  Calculate hit factor (where on the platform did the ball land?)
            {float x = hitLocation(transform.position, other.transform.position, other.collider.bounds.size.x);

            //  Calculate the new direction, and set length to 1
            Vector2 direction = new Vector2(x,1).normalized;

            //  Set ball's new direction and multiply with speed
            GetComponent<Rigidbody2D>().velocity = direction * ballSpeed;
            }
    }

/*    private void Update() {
        if(transform.position.y < -98){
            ballPosition.x = playerObject.transform.position.x;
            ballPosition.y = -80;
            transform.position = ballPosition;
            GetComponent<Rigidbody2D>().velocity = Vector2.up * ballSpeed;
        }
    }*/
}
