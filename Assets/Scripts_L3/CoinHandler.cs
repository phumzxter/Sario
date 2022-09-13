using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        //     if(other.tag == "Rock" || other.tag == "Van") {
        //     explosionParticle = Instantiate(explosionParticle, transform.position,  Quaternion.identity) as GameObject;
        //     Destroy (explosionParticle, 3);
        //     Destroy(other.gameObject);
        //     Destroy(gameObject);
           
        // } else if (other.tag == "Crate") {
        //     Destroy(gameObject);
        // }

        if (other.tag == "Player") {
            Debug.Log("Pick Coin");
            Destroy(gameObject);
            gameManager.GetComponent<GameManager>().addCoinScore();
        }

    }
}
