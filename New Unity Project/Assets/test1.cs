using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    //finalbarel bar;
    public GameObject hand;
    public Transform barrel;
    // Update is called once per frame
    void Start(){
        //bar = GetComponent<finalbarel>();
    }
    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            barrel.transform.SetParent(hand.transform);
        }
    }
    private void OnTriggerExit(Collider other){
        if(other.tag == "Player"){
            barrel.transform.SetParent(null);
        }
    }
}
