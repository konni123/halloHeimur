using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Score : MonoBehaviour
{
    public  Transform player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position.z);
        //scoreText.text =Convert.ToInt32 (player.position.z).ToString();
        scoreText.text =(player.position.z-20).ToString("0");
    }
}
