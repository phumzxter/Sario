using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionEffect : MonoBehaviour
{
    private ParticleSystem system;
    // Start is called before the first frame update
    void Start()
    {
        system = this.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void PlayParticle() {
        system.Play();
    }
}
