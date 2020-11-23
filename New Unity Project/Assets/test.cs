using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Transform cam;
    public Transform barrel;
    bool locationset;

    private void OnTriggerEnter(Collider other){
        /**
        if(!locationset && other.tag == "Player") {
            double time_ = 1f;
            while(time_ > .5f){
                barrel.transform.position += (barrel.position - cam.position) * Time.deltaTime ;
                time_ -= Time.deltaTime;
                Debug.Log("yurr");
            }
        }
        else if(other.tag == "HiddenTile"){
            locationset = true;
        }
        */
        if(other.tag == "Player"){
            barrel.position += (barrel.position - cam.position) * 2 ;
        }
        
    }

}
