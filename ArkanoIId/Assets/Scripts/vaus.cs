using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vaus : MonoBehaviour
{
    public float movementSpeed = 150;

    [SerializeField] GameObject ballPrefab;
    Rigidbody2D rb2d;
    Vector3 ballOffset;

    private void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start() {
        ball ball = GetComponentInChildren<ball>();
        ballOffset = ball.transform.position - transform.position;
    }

    private void FixedUpdate() {
        float horizontal = Input.GetAxisRaw("Horizontal");     //  Get the player's horizontal input
        GetComponent<Rigidbody2D>().velocity = Vector2.right * horizontal * movementSpeed;
    }

/*    private void Update() {
        if(Input.GetButtonDown("Jump")){
            ResetBall();
        }
    }*/

    public void ResetBall(){
        ball ball = Instantiate(ballPrefab).GetComponent<ball>();
        ball.transform.parent = transform;
        ball.transform.position = transform.position + ballOffset;
    }
}
