using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeBehavior : MonoBehaviour
{
//     private float startYPos;
//     private float startZPos;
//     private float startXPos;
//     // Start is called before the first frame update
//     void Start()
//     {
//         startXPos = transform.position.x;
//         startYPos = transform.position.y;
//         startZPos = transform.position.z;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//      float x = startXPos * Mathf.Sin(Time.time * .1f) * .1f;
//       float y = startYPos;
//       float z = startZPos;
 
// // Then assign a new vector3
//       gameObject.transform.position = new Vector3 (x, y, z);
//     }
  [Header("Info")]
   private Vector3 _startPos;
   private float _timer;
   private Vector3 _randomPos;
 
   [Header("Settings")]
   [Range(0f, 2f)]
   public float _time = 0.2f;
   [Range(0f, 2f)]
   public float _distance = 0.0001f;
   [Range(0f, 0.1f)]
   public float _delayBetweenShakes = 0f;
 
   private void Awake()
   {
       _startPos = transform.position;
   }
 
   private void OnValidate()
   {
       if (_delayBetweenShakes > _time)
           _delayBetweenShakes = _time;
   }
 
   public void Begin()
   {
       StopAllCoroutines();
       StartCoroutine(Shake());
   }
 
   private IEnumerator Shake()
   {
       _timer = 0f;
 
       while (_timer < _time)
       {
           _timer += Time.deltaTime;
 
           _randomPos = _startPos + (Random.insideUnitSphere * _distance);
 
           transform.position = _randomPos;
 
           if (_delayBetweenShakes > 0f)
           {
               yield return new WaitForSeconds(_delayBetweenShakes);
           }
           else
           {
               yield return null;
           }
       }
 
       transform.position = _startPos;
   }
}
