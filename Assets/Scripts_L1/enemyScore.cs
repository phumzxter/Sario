using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScore : MonoBehaviour
{


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player");
        {
            PlayerManager.numberOfEnemy++;
            Destroy(gameObject);
        }
    }
}
