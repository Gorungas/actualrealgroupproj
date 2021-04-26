using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossScript : MonoBehaviour
{
    public int level;

    public GameObject level1TP;
    public GameObject level2TP;

    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        level = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch(level)
            {
                case 0:
                    player.transform.position = level1TP.transform.position;
                    break;
                case 1:
                    player.transform.position = level2TP.transform.position;
                    break;
            }
        }
    }
}
