using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathWall : MonoBehaviour
{
    public AudioSource lossSound;

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ball"){
            Destroy(other.gameObject);
            lossSound.Play();
        }
    }
}
