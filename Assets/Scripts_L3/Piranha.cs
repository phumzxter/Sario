using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piranha : MonoBehaviour
{   
    public float speed;
    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // if (transform.position.y >= startPosition.y+ 10) {
        //     transform.position = Vector3.down * speed * Time.deltaTime;
        // } else if (transform.position.y < startPosition.y - 10) {
        //     transform.position = Vector3.up * speed * Time.deltaTime;
        // } else {
        //     Debug.Log("Between");
        // }
    } 
}
