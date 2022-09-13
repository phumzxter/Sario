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
        Destroy(gameObject, 0.5f);
    }

    public override void OnNextState() {
        state = 1;
        OnDead();

    }
  
}
