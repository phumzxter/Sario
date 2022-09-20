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

        if (other.tag == "Player") {
            Debug.Log("Pick Coin");
            Destroy(gameObject,0.4f);
            gameObject.transform.Find("Explosion_coin").gameObject.GetComponent<CollectionEffect>().PlayParticle();
            gameManager.GetComponent<GameManager>().addCoinScore();
        }

    }
}
