using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barreltrigger : MonoBehaviour
{
    public barrelscript barrelscript;
    //public AutoWalk walkingscript;
    
    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player") barrelscript.setinrange();
        //else if(other.tag == "BlockingObject")walkingscript.entered();
    }
    
    private void OnTriggerExit(Collider other){
        if(other.tag == "Player") barrelscript.resetinrange();
        //else if(other.tag == "BlockingObject") walkingscript.exited();
    }
    
}
