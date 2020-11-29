using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupManager : MonoBehaviour
{
    public GameObject placeback;

    public Vector3 placebackpos;
    
    public void placebackandDisable(){ //place back object and disable this object again
        if(placeback.tag == "barrel"){
            placeback.transform.parent = null;
        }
        else if(placeback.tag == "hammer"){
            GameObject.Find("Hamma").SetActive(false); //disable hamma
            placeback.SetActive(true); //set back orignial hammer to true
        }
        placeback.layer = 13;
        placeback.transform.position = placebackpos;
        gameObject.SetActive(false);
    }


}
