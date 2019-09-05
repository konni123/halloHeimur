using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollission : MonoBehaviour
{
    public PlayerMovement movement;
    //public GameManager gameManager;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        // Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag=="Kassi")
        {
            Debug.Log("Ég hitti kassa");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
