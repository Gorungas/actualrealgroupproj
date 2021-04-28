using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossScript : MonoBehaviour
{
    public int level;

    public GameObject level1TP;
    public GameObject level2TP;

    public GameObject player;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        level = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Cloud"))
        {
            print("coolididi");

            switch (level)
            {
                case 0:
                    player.transform.position = level1TP.transform.position;
                    break;
                case 1:
                    player.transform.position = level2TP.transform.position;
                    break;
            }
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
