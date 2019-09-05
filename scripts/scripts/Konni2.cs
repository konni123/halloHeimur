using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Konni2 : MonoBehaviour
{
    public float hradi = 300f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, hradi * Time.deltaTime);
    }
}
