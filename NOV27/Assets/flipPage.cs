using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class flipPage : MonoBehaviour
{
    Vector3 rotationalvect;
    Vector3 startpos;
    public float smoothing = 1f;
    
    private bool isOpenClicked;
    
    public AudioManager playSound;
    private DateTime startTime;
    private DateTime endTime;

    pageManager pages = null;


    void Start()
    {
        pages = FindObjectOfType<pageManager>();

    }
    
    void Update()
    {
        if(isOpenClicked){
            transform.Rotate(rotationalvect * Time.deltaTime);
            endTime = DateTime.Now;
            if ((endTime - startTime).TotalSeconds >= 1){
                isOpenClicked = false;
            }
        }
    }
    
    public void nextPage(){  
        isOpenClicked = true;
        startTime = DateTime.Now;

        
        playSound.Play("pageFlip");
        rotationalvect = new Vector3(0,180,0);
        pages.updatePage(1);
    }

    public void previousPage(){
        isOpenClicked = true;
        startTime = DateTime.Now;

        playSound.Play("pageFlip");
        rotationalvect = new Vector3(0,-180,0);
        pages.updatePage(0);
    }
}

