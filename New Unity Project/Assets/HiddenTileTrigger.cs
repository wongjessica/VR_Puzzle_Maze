using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    If its true rigidbody, not kinematic, only use physics like force to move the object, not using transform and changing its pos.
    
    static collider assume the object wont move at all so unity will perform some specific optimization for that and if u do move it, it will be costly
    rigidbody with kinematic says, maybe this object will move or wont
*/
public class HiddenTileTrigger : MonoBehaviour
{
    [SerializeField] private Transform HiddenTile = null;
    [SerializeField] private Transform HiddenCab = null;

    [SerializeField] private Vector3 downTile = new Vector3(4.3125f, -0.75f, -11f);
    [SerializeField] private Vector3 upTile = new Vector3(4.3125f, -0.375f, -11f);
    
    [SerializeField] private Vector3 closeCab = new Vector3(10f, 0, -7.5f);
    [SerializeField] private Vector3 openCab = new Vector3(10f, 0, -10.0625f);

    private float openSpeed = 3;
    private float cabopenSpeed = 1;

    private bool Triggered = false;
    private float timer = .5f;

    private bool playerOn = false;
    private bool barrelOn = false;

    // Update is called once per frame
    void Update()
    {
        if(Triggered){
            HiddenTile.position = Vector3.Lerp(HiddenTile.position, downTile, Time.deltaTime * openSpeed);
            /**
            if(HiddenTile.position == downTile){
                HiddenCab.position = Vector3.Lerp(HiddenCab.position, openCab, Time.deltaTime * openSpeed);
            }
            */

            if (timer > 0f) {
                timer -= Time.deltaTime;
            }
            if (timer <= 0f) {
                HiddenCab.position = Vector3.Lerp(HiddenCab.position, openCab, Time.deltaTime * cabopenSpeed );
            }
        }
        else{
            HiddenTile.position = Vector3.Lerp(HiddenTile.position, upTile, Time.deltaTime * openSpeed);
            HiddenCab.position = Vector3.Lerp(HiddenCab.position, closeCab, Time.deltaTime * 2);
        }
    }
    
    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player") playerOn = true;
        else if (other.tag == "Barrel" ) barrelOn = true;
        if(playerOn != barrelOn){
            //Debug.Log(gameObject.name + " triggered by " + other.gameObject.name); 
            tileDown();
            //AudioManager.PlaySound("cabOpen");
            FindObjectOfType<AudioManager>().Play("cabOpen");
        }
        
    }
    private void OnTriggerExit(Collider other){
        timer = .5f;
        //Debug.Log(gameObject.name + " triggered by " + other.gameObject.name); 
        if(other.tag == "Player") playerOn = false;
        else if (other.tag == "Barrel" ) barrelOn = false;
        if(playerOn == false && barrelOn == false){
            tileUp();
        }
    }

    private void tileDown(){
        Triggered = true;
    }

    private void tileUp(){
        Triggered = false;
    }
}
