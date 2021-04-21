using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameTP : MonoBehaviour
{
    public Transform tpOut;
    public GameObject player;
    public Camera cam1;
    public Transform camTP;

    public Material skybox2;

    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.transform.position = tpOut.transform.position;
            cam1.transform.position = camTP.position;
            RenderSettings.skybox = skybox2;
        }
    }

}
