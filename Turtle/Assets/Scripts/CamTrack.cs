using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrack : MonoBehaviour
{
    public Transform playerPos;
    
    public bool track2d = false;

    public float offset = 10.0f;
    public Transform camPos; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(playerPos);
        if (track2d) {
            camPos.position = playerPos.position + new Vector3(offset, 0, 0);
            camPos.rotation = Quaternion.Euler(90, 0, 0);
            transform.LookAt(playerPos);
        }
    }
}
