using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

using System;

public class Activate : MonoBehaviour, IPointerClickHandler
{
    public static event Action<string, int> Activated = delegate { };

    public Animator resetBlock;

    public static bool resetting;
    
    void Start(){
    }
    
    public void OnPointerClick(PointerEventData pointerEventData) {
        if(!finalpuzzleManager.begincountdown) finalpuzzleManager.begincountdown = true;
        gameObject.layer = 12;
        resetBlock.SetBool("triggered", true);
        //gameObject.layer = 12;
        Activated(name, 1);
    
    }

    public void Reset(){
        //resetBlock.SetBool("triggered", false);
        gameObject.layer = 11;
    }
    public void TimesUp(){
        gameObject.layer = 12;
    }
    public void ResetAnimation(){
        resetBlock.SetBool("triggered", false);
    }
}

/**
public class Activate : MonoBehaviour, IPointerClickHandler
{
    public static event Action<string, int> Activated = delegate { };

    //public Animator resetBlock;
    
    Vector3 beginpos;
    Vector3 endpos;
    void Start(){
        beginpos = transform.localPosition;
        endpos = transform.localPosition + new Vector3(.3125f, 0 , 0);
    }
    
    public void OnPointerClick(PointerEventData pointerEventData) {
        if(!finalpuzzleManager.begincountdown) finalpuzzleManager.begincountdown = true;
        //resetBlock.SetBool("triggered", true);
        Blockdown();
        Debug.Log("hello");
        gameObject.layer = 12;
        Activated(name, 1);
    }

    public void Reset(){
        //resetBlock.SetBool("triggered", false);
        gameObject.layer = 11;
    }

    private IEnumerator Blockdown(){
        while(Vector3.Distance(endpos, beginpos) > 0.005f){
            transform.localPosition = Vector3.Lerp(beginpos, endpos, 1* Time.deltaTime);
            yield return null;
        }
        //Activated(name, 1);
    }
}
*/