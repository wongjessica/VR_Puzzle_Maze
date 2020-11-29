using UnityEngine;
using System.Collections;
 
public class ObjectRespawn : MonoBehaviour {
     public float lowerYbounds = 0f;
     public float upperYbounds = 4.367188f;
     public float Zbounds = 0.05f;
     Vector3 original_position;

     void Start () {
         original_position = this.transform.position;
     }
 
     void FixedUpdate () {
         if ((transform.position.y < lowerYbounds) || (transform.position.y > upperYbounds) || (transform.position.z < Zbounds))
         {
             transform.position = original_position;
         }
     }
  }