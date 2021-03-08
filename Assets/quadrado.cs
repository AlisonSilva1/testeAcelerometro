using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quadrado : MonoBehaviour
{
     Rigidbody rb;
     public float vel = 3f;
     
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(Input.acceleration.x * vel, 0, Input.acceleration.y * vel);
    }
}
