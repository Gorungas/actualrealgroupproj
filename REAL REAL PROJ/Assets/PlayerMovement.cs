using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 100.0f;
    public float rotationSpeed = 100.0f;
    public float jumpHeight = 10.0f;
    public float gravity = -1.0f;
    public Transform tpOut;

    public bool isOnGround;

    public Rigidbody playerRigid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float trans = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        float jump = Input.GetAxis("Jump") * jumpHeight;
        float grav = Input.GetAxis("Fire1") * gravity;

        trans *= Time.deltaTime;
        rotation *= Time.deltaTime;
       
        playerRigid.AddForce(0, 0, trans);
        playerRigid.AddForce(rotation, 0, 0);
        if (isOnGround)
        {
            playerRigid.AddForce(0, jump, 0);
            isOnGround = false;
        }
        //Physics.gravity = new Vector3(0, gravity, 0);
    }

    private void OnCollisionStay()
    {
        isOnGround = true;
    }

    

}
