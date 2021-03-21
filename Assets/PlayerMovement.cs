using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if()
    }
}
