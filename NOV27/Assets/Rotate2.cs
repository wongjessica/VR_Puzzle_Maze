using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

using System;

public class Rotate2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public static event Action<string, int> Rotated = delegate { };
    private bool coroutineAllowed;
    private int numberShown;
    
    public bool gazedAt;
    public Transform cam;

    void Start(){
        coroutineAllowed = true;
        numberShown = 0;
    }
    
    void Update(){
        if(gazedAt){
            RaycastHit hit;
            int layerMask = 15;
            Ray approach = new Ray(cam.position, cam.TransformDirection(Vector3.forward)); //the ray info, from where and 
            if(Physics.Raycast(approach, out hit, 5f, layerMask)){ //raycast done if it hits nothing
                if(coroutineAllowed) StartCoroutine("RotateWheel");
                //else gazedAt = false;
            }
        }
    }
    public void OnPointerEnter(PointerEventData pointerEventData) {
        gazedAt = true;
    }
    public void OnPointerExit(PointerEventData pointerEventData) {
        gazedAt = false;
    }

    private IEnumerator RotateWheel(){
        coroutineAllowed = false;

        for (int i = 0; i <= 11; i++){
            transform.Rotate(0f, 3f, 0f);
            yield return new WaitForSeconds(0.1f);
        }

        coroutineAllowed = true;
        numberShown += 1;

        if (numberShown > 9){
            numberShown = 0;
        }
        Rotated(name, numberShown);
    }
}
