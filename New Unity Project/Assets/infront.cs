using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infront : MonoBehaviour
{
    //public GameObject mainCam;
    public Camera mainCam;
    public float distance;
    public float smoothness;

    void Start(){
        transform.rotation = Quaternion.Euler(17,0,0);
    }
    void Update (){
        transform.position = mainCam.transform.position + mainCam.transform.forward * distance;
        transform.rotation = mainCam.transform.rotation;
        gameObject.layer = 10;
    }
    // Start is called before the first frame update
    /**
    void Start()
    {
        transform.SetParent(parent);
        transform.localPosition = new Vector3(0, 0, 0);
        gameObject.layer = 10;
    }
    */
}
