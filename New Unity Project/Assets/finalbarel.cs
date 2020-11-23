using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalbarel : MonoBehaviour
{
    public Transform cam;
    public Transform barrel;
    public float speed = 2f;
    //public Animator barmove;

    void Update(){
        float step =  speed * Time.deltaTime;
        barrel.position = barrel.position + cam.forward * step;
        //transform.position = transform.position + cam.forward * step;
        
    }
}
