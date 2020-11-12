using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class KeypadKey : MonoBehaviour, IPointerClickHandler
{
    public string key;

    public void OnPointerClick(PointerEventData PointerEventData){
        SendKey();
    }
    
    public void SendKey()
    {   
        this.transform.GetComponentInParent<KeypadController>().PasswordEntry(key);
 
    }

}
