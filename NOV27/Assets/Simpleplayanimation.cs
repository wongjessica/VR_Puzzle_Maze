using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simpleplayanimation : MonoBehaviour
{
    public Animator openAnimator;
    bool isOpened;

    public void triggerAnimation(){
        if(!isOpened){
            openAnimator.SetBool("opened", true); 
            isOpened = true;
        }
        else{
            openAnimator.SetBool("opened", false);
        }
    }
}
