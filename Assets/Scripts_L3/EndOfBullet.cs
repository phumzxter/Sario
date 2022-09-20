using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfBullet : MonoBehaviour
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

        if (other.tag == "Bullet") {
            Destroy(gameObject,0.4f);
            gameObject.transform.Find("Explosion_coin").gameObject.GetComponent<CollectionEffect>().PlayParticle();
        }

    }
}
