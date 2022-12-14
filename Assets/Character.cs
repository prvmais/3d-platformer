using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
     float maxSpeed = 1.5f;
     float rotation = 0.0f;
     float camRotation = 0.0f;
     GameObject cam;
     float rotationSpeed = 2.0f;
     float camRotationSpeed = 1.5f;
     Rigidbody myRigidbody;

     bool isOnGround;
     public GameObject groundChecker;
     public LayerMask groundLayer;
     public float jumpForce = 300.0f;

     public AudioClip jump;
     public AudioClip backgroundMusic;

     public AudioSource sfxPlayer;
     public AudioSource musicPlayer;

     


    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        myRigidbody = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;

       // musicPlayer.clip = backgroundMusic;
        //musicPlayer.loop = true;
        //musicPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        
       transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * 3f);

       isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);
<<<<<<< Updated upstream:Assets/Character.cs

                 Debug.Log(isOnGround);

       if (isOnGround == true && Input.GetKeyDown(KeyCode.Space))
       {

         myRigidbody.AddForce(transform.up * jumpForce);
       }
    
       //Debug.Log("OnGround");
=======
       if (isOnGround == true && Input.GetKeyDown(KeyCode.Space))
       {
         myRigidBody.AddForce(transform.up * jumpForce)
       }
>>>>>>> Stashed changes:Assets/CharacterController.cs
       
       Vector3 newVelocity = transform.forward * Input.GetAxis("Vertical") * maxSpeed;
       myRigidbody.velocity = new Vector3(newVelocity.x, myRigidbody.velocity.y, newVelocity.z);

        rotation= rotation + Input.GetAxis("Mouse X") * rotationSpeed;
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));

        camRotation = camRotation + Input.GetAxis("Mouse Y") * camRotationSpeed;
        //cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));

        
       
    }
}
