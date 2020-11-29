using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ButtonTrig : MonoBehaviour, IPointerClickHandler
{
    public Animator pcbutton;
    public GameObject minitorInterface;
    public GameObject warning;
    public AudioManager instance;
    public void OnPointerClick(PointerEventData PointerEventData){
        instance.Play("pcon");
        pcbutton.SetBool("turnon", true);
        gameObject.layer = 12;
    }

    public void turnonMonitor(){
        minitorInterface.SetActive(true);
        warning.SetActive(false);
    }

}
