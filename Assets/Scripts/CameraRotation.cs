using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{

    public GameObject player;
    private float m_rotationSpeed = 200;
    // Start is called before the first frame update
    void Start()
    {
       
        //playerCamera.transform.position = playerFollower.transform.position + new Vector3(0, 1, -5);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Rotate(Vector3.down, horizontalInput * m_rotationSpeed * Time.deltaTime);

        transform.position = player.transform.position;
    }
}
