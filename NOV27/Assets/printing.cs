using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class printing : MonoBehaviour, IPointerClickHandler
{
    public bool loadedPaper;
    public GameObject printerWarning; 
    public AudioManager instance;

    public Animator paperPrinting;
    public Animator resultsPrinting;
    
    public void OnPointerClick(PointerEventData PointerEventData){
        if(!loadedPaper){
            printerWarning.SetActive(true);
        }
        else{
            paperPrinting.SetBool("printing", true);
            resultsPrinting.SetBool("printing", true);
            instance.Play("printing");
            this.enabled = false;
            //this.GetComponent<Button>().enabled = false;
        }
    }

    void Start(){}
}
