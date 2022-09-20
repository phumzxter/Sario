using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTimer : MonoBehaviour
{
    public float timeRemaining;
    private bool isTouch;
    public GameObject topGameObject;
    // Start is called before the first frame update
    void Start()
    {
        isTouch = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining <= 0) {
            if (topGameObject != null) {
                topGameObject.GetComponent<Rigidbody>().isKinematic = false;
            }
            Destroy(gameObject);
          
        }
        if (isTouch) {
            StartCounting();
            GameObject shake = (gameObject.transform.Find("platformTimer").gameObject).transform.Find("shake").gameObject;
            shake.GetComponent<ShakeBehavior>().Begin();
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
