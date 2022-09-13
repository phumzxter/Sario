using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController_L3 : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
         transform.position = player.transform.position + new Vector3(-1.45f, 3.09f, -10.73f);
    }
}
