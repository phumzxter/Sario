using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnermy : MonoBehaviour
{
    protected float speed;
    protected int state;
    private Vector3 velocity;

    abstract protected void Init();
    // Start is called before the first frame update
    void Start()
    {
        state = 0;
       
    }

    void Awake() {
         Init();
     }

    // // Update is called once per frame
    void Update()
    {
        if (state == 0) {
              OnWalk();
        }
      
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle") {
            transform.Rotate(0, 180, 0); 
        }

        if (other.tag == "Player") {
            
            if (other.transform.position.y >= gameObject.transform.position.y + 0.5) {
                 Debug.Log("Change state");
                OnNextState();
            } else {
                // set player state to die
                // set gamestate to gameover
                PlayerController_L3 script =  other.GetComponent<PlayerController_L3>();
                if (script.state == 0) {
                    script.state = 1;
                    script.OnDieState();
                }
               
            }
        }

    }

    public void OnWalk() {
    
        gameObject.transform.Translate(Vector3.forward * Time.deltaTime  * speed);
        
    }

    public abstract void OnDead();
    public abstract void OnNextState();
}
