using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && gameObject.tag == "Water") {
             PlayerController_L3 script =  other.GetComponent<PlayerController_L3>();
                if (script.state == 0) {
                    script.state = 1;
                    script.OnDieState();
                }
        } else {
            Destroy(other);
        }    
    }
}
