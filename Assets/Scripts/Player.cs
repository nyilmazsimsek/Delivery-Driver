using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float steerSpeed = 3f;
    [SerializeField] private float moveSpeed = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
        float moveSpeedAmount = Input.GetAxis("Vertical") * moveSpeed;
        transform.Rotate(0,0,-steerAmount * Time.deltaTime); 
        transform.Translate(0, moveSpeedAmount * Time.deltaTime, 0);
    }
}
