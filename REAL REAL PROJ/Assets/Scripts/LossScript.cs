using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossScript : MonoBehaviour
{
    public int level;

    public Transform level1TP;
    public Transform level2TP;
    public Transform level3TP;

    public GameObject player;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Cloud") || other.gameObject.CompareTag("Beak"))
        {
            print("coolididi");

            switch (level)
            {
                case 0:
                    player.transform.position = level1TP.position;
                    break;
                case 1:
                    player.transform.position = level2TP.position;
                    break;
                case 2:
                    player.transform.position = level3TP.position;
                    break;
            }
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
