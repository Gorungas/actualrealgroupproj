using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 100.0f;
    public float rotationSpeed = 100.0f;
    public Vector3 gravity;
    public Transform tpOut;

    public bool move2d = false;

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
        if (!move2d)
        {
            trans *= Time.deltaTime;
            rotation *= Time.deltaTime;

            playerRigid.AddForce(0, 0, trans);
            playerRigid.AddForce(rotation, 0, 0);
        }


        if (move2d)
        {
            trans = Input.GetAxis("Horizontal") * speed;

            trans *= Time.deltaTime;
            playerRigid.AddForce(0, 0, trans);

            playerRigid.AddForce(gravity);
            playerRigid.useGravity = false;


            if (Input.GetKeyDown(KeyCode.Space))
            {
                gravity *= -1;

            }

        }
    }

    private void OnCollisionStay()
    {
        isOnGround = true;
    }



}
