using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class bookcoveropen : MonoBehaviour
{
    public GameObject closeBook;
    public GameObject openBook;

    public Button openButton;
    bool isOpenClicked;
    
    bool iscloseClicked;

    Vector3 rotationalvect;
    public float smoothing = 1f;
    private bool done;
    public AudioManager playSound;

    private DateTime startTime;
    private DateTime endTime;

    void Start()
    {
        openButton.onClick.AddListener(openBtn_Click);
    }
    
    void Update()
    {
        if(isOpenClicked){
            transform.Rotate(rotationalvect * Time.deltaTime);
            endTime = DateTime.Now;
            if ((endTime - startTime).TotalSeconds >= 1){
                isOpenClicked = false;
                closeBook.SetActive(false);
                openBook.SetActive(true);
            }
        }
        else if(iscloseClicked){
            transform.Rotate(rotationalvect * Time.deltaTime);
            endTime = DateTime.Now;
            if ((endTime - startTime).TotalSeconds >= .995){
                iscloseClicked = false;
                //closeBook.SetActive(true);
                closeBook.transform.parent.gameObject.SetActive(false);
            }
        }
    }
    
    private void openBtn_Click(){
        rotationalvect = new Vector3(0,180,0);
        isOpenClicked = true;
        startTime = DateTime.Now;
        
        playSound.Play("coverOpen");
    }

    public void closeBtn_Click(){
        rotationalvect = new Vector3(0,-180,0);
        iscloseClicked = true;
        startTime = DateTime.Now;
        
        playSound.Play("coverOpen");
    }
}

/**
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class bookcoveropen : MonoBehaviour
{
    public Button openButton;
    private bool isOpenClicked;
    Quaternion target;
    Vector3 rotationalvect;
    public float smoothing = 1f;
    public bool done;
    public AudioManager playSound;

    private DateTime startTime;
    private DateTime endTime;

    void Start()
    {
        if(openButton != null){
            openButton.onClick.AddListener(openBtn_Click);
        }
        target = Quaternion.Euler(0,-180,0);
        rotationalvect = new Vector3(0,180,0);
    }
    
    void Update()
    {
        
        if(!done && isOpenClicked){
            transform.rotation = Quaternion.Lerp(transform.rotation, target, smoothing * Time.deltaTime);
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, target, Time.deltaTime);
            //transform.Rotate(rotationalvect * Time.deltaTime);
            if(Quaternion.Angle(target, transform.rotation) < 0.05f) done = true;
        }
        
        if(isOpenClicked){
            transform.Rotate(rotationalvect * Time.deltaTime);
            endTime = DateTime.Now;
            if ((endTime - startTime).TotalSeconds >= 1){
                isOpenClicked = false;
            }
        }
    }
    
    private void openBtn_Click(){
        isOpenClicked = true;
        startTime = DateTime.Now;
        
        playSound.Play("coverOpen");
        //start_time
        //Quaternion book = Quaternion.Euler(0f,180f,0f);
        //StartCoroutine(MyCoroutine(book));
        //transform.Rotate(0f, 180f, 0f);
        
    }

    
    IEnumerator MyCoroutine(Quaternion target){
        while(Quaternion.Angle(transform.rotation, target) > 0.05f){
            transform.rotation = Quaternion.Lerp(transform.rotation, target, smoothing * Time.deltaTime);
            Debug.Log("Yurrr");
        }
        yield return null;
        //Debug.Log("Yurrr");

        yield return new WaitForSeconds(3f);
        Debug.Log("brrrrr");
    }
    
}
*/