using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public MoveEllen ellen;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ellen"))
        {
            
            ellen.Death();
        }
    }
}
