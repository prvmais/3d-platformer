  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
     float maxSpeed = 3.0f;
     float rotation = 0.0f;
     float camRotation = 0.0f;
     GameObject cam;
     float rotationSpeed = 2.0f;
     float camRotationSpeed = 1.5f;
     Rigidbody myRigidbody;

     bool isOnGround;
     public GameObject groundChecker;
     public LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
       // transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical"));

       isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);
       if (isOnGround == true && Input.GetKeyDown(KeyCode.Space))
       {
         myRigidBody.AddForce(transform.up * jumpForce)
       }
       
       Vector3 newVelocity = transform.forward * Input.GetAxis("Vertical") * maxSpeed;
       myRigidbody.velocity = new Vector3(newVelocity.x, myRigidbody.velocity.y, newVelocity.z);

        rotation= rotation + Input.GetAxis("Mouse X") * rotationSpeed;
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));

        camRotation = camRotation + Input.GetAxis("Mouse Y") * camRotationSpeed;
        cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));
       
    }
}
