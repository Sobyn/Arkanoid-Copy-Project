using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float ballSpeed = 100f;
    public AudioSource hitSound;
    public GameObject playerObject;
    private Vector2 ballPosition;
    float hitLocation(Vector2 ballPos, Vector2 vausPos, float vausWidth){
        return(ballPos.x - vausPos.x) / vausWidth;}

    void Start(){
        GetComponent<Rigidbody2D>().velocity = Vector2.up * ballSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Block"){
            hitSound.Play();            
        }


        if(other.gameObject.name == "vaus"){
            float x = hitLocation(transform.position, other.transform.position, other.collider.bounds.size.x);
            Vector2 direction = new Vector2(x,1).normalized;
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
