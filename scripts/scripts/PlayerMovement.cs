using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    
    //public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log("leikur byrjaður");
        rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, hradi*Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (rb.position.y<-1f)
        {
            gameManager.EndGame();
        }
        /*eða svona
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }*/
    }

}
