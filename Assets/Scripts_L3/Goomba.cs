using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : BaseEnermy
{
    public float startSpeed;
    protected override void Init ()
     {
    
         speed = startSpeed;
     }

    public override void OnDead() {
        // state = 1;
        
        Destroy(gameObject, 0.4f);
        gameObject.transform.Find("Explosion_Skull").gameObject.GetComponent<KillEffect>().PlayParticle();
    }

    public override void OnNextState() {
        state = 1;
        OnDead();

    }
  
}
