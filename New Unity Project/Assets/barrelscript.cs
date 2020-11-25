using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class barrelscript : MonoBehaviour, IPointerClickHandler
{
    //private Vector3 relativePosition;
    //private Vector3 wantedPosition;

    public Transform hand;
    public Transform cam;
    public Transform Tile;

    //public GameObject placeback; //the placeback object
    public bool grabbed = false; 
    public bool inrange = false;
    private bool raycastnothit;

    Vector3 barreltile;
    public void OnPointerClick(PointerEventData pointerEventData){
        transform.SetParent(hand);
        transform.localPosition = new Vector3(0, 0, 0);
        gameObject.layer = 12;
        grabbed = true;
        //placeback.SetActive(true); //once clicked, picked up, set the palcebackobj true so we can put it back
    }

    void Start(){
        barreltile = new Vector3(5.2f, 0f, -12.3125f);
    }
    void Update(){
        if(grabbed && !raycastnothit){
            RaycastHit hit;
            int layerMask = 1 << 13;
            Ray approach = new Ray(cam.position, cam.TransformDirection(Vector3.forward)); //the ray info, from where and 
            if(Physics.Raycast(approach, out hit, 5f, layerMask)){ //raycast done if it hits nothing
                transform.SetParent(null);
                transform.position = barreltile;
                gameObject.AddComponent<Rigidbody>();
                gameObject.layer = 12;
                raycastnothit = true;

                //transform.SetParent(Tile);

                //transform.rotation.eulerAngles = new Vector3(0,0,0);
            }
        }
    }

    /**
    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){ 
            inrange = true;
            game_object.transform.SetParent(hand.transform);
        }
    }
    
    private void OnTriggerExit(Collider other){
        if(other.tag == "Player") inrange = false;
        game_object.transform.SetParent(null);

    }
    
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
    */
}
