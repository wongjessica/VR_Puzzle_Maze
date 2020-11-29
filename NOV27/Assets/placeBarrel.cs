using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class placeBarrel : MonoBehaviour, IPointerClickHandler
{
    public static bool hasBarrel;
    public Transform barrel;
    public void OnPointerClick(PointerEventData pointerEventData){
        if(hasBarrel){
            barrel.parent = null;
            barrel.position = new Vector3(5.28125f, 0f, -11.9375f);
        }
    }
}
