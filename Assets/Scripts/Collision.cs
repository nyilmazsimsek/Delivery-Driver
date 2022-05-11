using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision object: " + col.collider.name);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Square triggered!");
    }
}
