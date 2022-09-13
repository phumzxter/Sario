using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koopa : BaseEnermy
{
    public float startSpeed;
    protected override void Init ()
     {
         
         speed = startSpeed;
     }

    public override void OnDead() {
        // state = 1;
        Destroy(gameObject);
    }

    public override void OnNextState() {
        state = 1;
        //Play some animation
        OnDead();
    }

    // public override void OnWalk() {
        
    //         gameObject.transform.Translate(Vector3.forward * Time.deltaTime * dirX * speed);
    //         OnNextState();
    //         // OnDead();
        
    // }

    // void Update()
    // {
    //     OnWalk();
    //     Debug.Log("run update");
    // }

    // void SheelState() {
    //     if (state == 1) {

    //     }
    // }

}
