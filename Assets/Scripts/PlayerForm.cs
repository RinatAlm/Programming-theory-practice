using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForm : PlayerController // INHERITANCE
{
    public GameObject player;
    private void Start()
    {
        m_speed = 20.0f;
    }
    public override void Move(int direction)//PLYMORPHISM
    {
        playerRb.AddForce(playerFollower.transform.forward * direction * m_speed);
        playerRb.AddForce(playerFollower.transform.up * direction * m_speed);
    }
    public override void ChangePlayer()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.SetActive(true);
            playerForm.SetActive(false);
           
        }
    }
}
