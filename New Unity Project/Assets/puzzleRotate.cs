using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class puzzleRotate : MonoBehaviour, IPointerClickHandler
{   
    public void OnPointerClick(PointerEventData pointerEventData){
        if(!puzzleManager.Win){
            transform.Rotate(0f,0f,90f);
        }
    }

    
}
