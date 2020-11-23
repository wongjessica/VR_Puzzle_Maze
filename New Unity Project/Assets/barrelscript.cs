using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelscript : MonoBehaviour
{
    private Vector3 relativePosition;
    private Vector3 wantedPosition;

    public GameObject hand;
    public GameObject game_object;

    public bool grabbed = false; 
    public bool inrange = false;
    
    void Update(){
        if(grabbed){
            transform.rotation = hand.transform.rotation;
            transform.position = hand.transform.position + hand.transform.forward*2;
        }

    }
    /**
    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){ inrange = true;}
    }
    
    private void OnTriggerExit(Collider other){
        if(other.tag == "Player") inrange = false;
    }
    */
    public void setinrange(){
        inrange = true;
    }
    public void resetinrange(){
        inrange = false;
    }
    public void clicked(){
        if(inrange && !grabbed){
            //game_object.transform.SetParent(hand.transform);
            //game_object.transform.localPosition = hand.transform.localPosition;
            grabbed = true;
        }
    }
}
