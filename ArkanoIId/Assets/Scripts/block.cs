using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    public int health = 1;
    [SerializeField] int scoreValue = 10;

    private void OnCollisionEnter2D(Collision2D other) {
            if(other.gameObject.tag == "Ball"){
                health--;
                if(health <= 0){
                    FindObjectOfType<GameSession>().IncreaseScore(scoreValue);
                    Destroy(gameObject);
                }
            }
    }
            
}
