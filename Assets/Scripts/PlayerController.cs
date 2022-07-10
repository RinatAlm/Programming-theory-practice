using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;
    public Camera playerCamera;
    public GameObject playerFollower;
    public GameObject playerForm;
    public PlayerController playerFormController;
    public Camera playerFormCamera;
    public Text changeText;
   public float m_speed = 5.0f;
    public float speed
    {
        get { return m_speed; }
        set
        {
            if (value < 0.0f)
            {
                Debug.Log("Negtive number can't be used");
            }
            else
            {
                m_speed = value;
            }

        }
    }//ENCAPSULATION

  
    

    private void Start()
    {
        changeText = GameObject.Find("Change").GetComponent<Text>();      
        speed = -22;// Tried to set negative number
        playerRb = gameObject.GetComponent<Rigidbody>();      
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Move(1);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            Move(-1);
        }
       
        if(Vector3.Distance(gameObject.transform.position,playerForm.transform.position)<5.0f)
        {
            changeText.enabled = true;
            ChangePlayer();
        }
        else
        {
            changeText.enabled=false;
        }
        
    }

  public virtual void Move(int direction)//ABSTRACTION
    {
        playerRb.AddForce(playerFollower.transform.forward * direction * m_speed);
    }

    public virtual void ChangePlayer()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerForm.SetActive(true);
            gameObject.SetActive(false);
        }
        
    }
}
