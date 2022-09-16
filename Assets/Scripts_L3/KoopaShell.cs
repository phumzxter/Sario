using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoopaShell : MonoBehaviour
{
    private float speed;
    private int dirX;
    private GameObject shellObject;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        dirX = 0;
        shellObject = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (dirX > 0) {
            MoveRight();
        } else if(dirX < 0) {
            MoveLeft();
        }
    }

     void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "RightHitBox" && other.tag == "Player") {
            dirX = 1;
        } else if (gameObject.tag == "LeftHitBox" && other.tag == "Player") {
           dirX = -1;
        }
        // }else if(gameObject.tag == "RightHitBox" && other.tag == "Obstacle") {
        //     dirX = 1;
        // } else if (gameObject.tag == "LeftHitBox" && other.tag == "Obstacle") {
        //    dirX = -1;
        // }
    }

    private void MoveLeft() {
        shellObject.transform.Translate(Vector3.forward * Time.deltaTime  * speed);
    }

    private void MoveRight() {
        shellObject.transform.Translate(Vector3.back * Time.deltaTime  * speed);
    }
}
