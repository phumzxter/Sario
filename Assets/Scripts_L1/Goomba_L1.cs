using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba_L1 : MonoBehaviour
{

    public float speed;

    public bool MoveRight;

    public GameObject GameOverScreen;

    void Update () 
    {
        if (MoveRight)
        {
            transform.Translate(0, 0, 1 * Time.deltaTime * speed);
            transform.localScale = new Vector3 (1,1,1);
        }
        else
        {
            transform.Translate(0, 0, -1 * Time.deltaTime * speed);
            transform.localScale = new Vector3 (1,1,-1);
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            GameOverScreen.SetActive(true);
        }
        
        if (other.gameObject.CompareTag("turn"))
        {
            if(MoveRight)
            {
                MoveRight = false;
            }
            else
            {
                MoveRight = true;
            }
        }
    }
    
}
