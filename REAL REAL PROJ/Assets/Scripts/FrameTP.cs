using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameTP : MonoBehaviour
{
    public Transform tpOut;
    public GameObject player;
    public Camera cam1;
    public Transform camTP;
    public Rigidbody rb;
    public CamTrack tracker;
    public PlayerMovement mover;
    public bool hasBeenEntered = false;

    public LossScript loss;

    public Material skybox2;

    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        rb = player.GetComponent<Rigidbody>();
        tracker = cam1.GetComponent<CamTrack>();
        mover = player.GetComponent<PlayerMovement>();


   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (loss.level == -1)
            {
                player.transform.position = tpOut.transform.position;
                cam1.transform.position = camTP.position;
                RenderSettings.skybox = skybox2;
                rb.constraints = RigidbodyConstraints.FreezePositionX;



                tracker.track2d = true;
                mover.move2d = true;


                rb.angularVelocity = Vector3.zero;
                rb.velocity = Vector3.zero;


            }
            if (!hasBeenEntered)
            {
                loss.level++;
                hasBeenEntered = true;
            }
            
        }
    }

}
