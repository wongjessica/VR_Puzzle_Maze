using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class garbagetest : MonoBehaviour, IPointerClickHandler
{
    public Animator testing;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnPointerClick(PointerEventData pointerEventData){
        testing.SetBool("triggered", true);
    }
    
}
