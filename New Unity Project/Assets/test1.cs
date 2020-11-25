using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    finalbarel bar;
    // Update is called once per frame
    void Start(){
        bar = GetComponent<finalbarel>();
    }
    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            bar.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other){
        if(other.tag == "Player"){
            bar.enabled = false;
        }
    }
}
