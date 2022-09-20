using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController_L1 : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(7.08f, 3.77f, -10.91f);
    }
}
