using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koopa : BaseEnermy
{
    public float startSpeed;
    public GameObject shell;
    protected override void Init ()
     {
         
         speed = startSpeed;
     }

    public override void OnDead() {
        Instantiate(shell,transform.position,transform.rotation);
        Destroy(gameObject);     
    }

    public override void OnNextState() {
        state = 1;
        //Play some animation
        OnDead();
    }

}
