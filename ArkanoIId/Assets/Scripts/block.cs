using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    [SerializeField] int health = 1;

    private void OnCollisionEnter2D(Collision2D other) {
            if(other.gameObject.tag == "Ball"){
                health--;
                if(health <= 0){
                    Destroy(gameObject);
                }
            }
    }
            
}
