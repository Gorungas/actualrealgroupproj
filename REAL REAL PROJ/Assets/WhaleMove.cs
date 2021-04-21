using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleMove : MonoBehaviour
{
    public float minimumHeight = -10.0f;
    public float maximumHeight = 3.0f;
    public Transform whalePos;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (whalePos.transform.position.y >= maximumHeight)
            whalePos.transform.position += new Vector3(0, speed, 0);

        else if (whalePos.transform.position.y <= minimumHeight)
            whalePos.transform.position += new Vector3(0, speed * -1, 0);
    }
}
