using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTimer : MonoBehaviour
{
    public float timeRemaining;
    private bool isTouch;
    // Start is called before the first frame update
    void Start()
    {
        isTouch = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining <= 0) {
            Destroy(gameObject);
        }
        if (isTouch) {
            StartCounting();
        }
    }

    private void StartCounting() {

        if (timeRemaining > -1 && isTouch) {
            timeRemaining -= Time.deltaTime;
             Debug.Log(timeRemaining);
             Debug.Log("start count");

        }
    }

     private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && gameObject.tag == "Timer") {isTouch = true;  }    
    }
}
