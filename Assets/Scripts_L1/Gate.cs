using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gate : MonoBehaviour
{

    public GameObject StagePassScreen;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player");
        {
            StagePassScreen.SetActive(true);
        }
    }
}
