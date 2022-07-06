using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;
    public Camera playerCamera;
    public GameObject playerFollower;
    public float speed = 200;
    public float rotationSpeed = 50;

    private void Start()
    {
       
        playerRb = GameObject.Find("Player").GetComponent<Rigidbody>();
        playerFollower = GameObject.Find("PlayerFollower");
        playerCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerRb.AddForce(playerFollower.transform.forward * speed);
        }
       
        
        
    }

  
}
