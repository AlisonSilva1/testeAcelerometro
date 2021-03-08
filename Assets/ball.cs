using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    Rigidbody rb;

    public float vel = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate(){
        //pegando o acelerometro do celular
        rb.velocity = new Vector3(Input.acceleration.x* vel, 0 , Input.acceleration.y*vel);

    }
}
