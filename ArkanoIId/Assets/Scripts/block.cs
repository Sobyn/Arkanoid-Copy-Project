using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
    }
}
