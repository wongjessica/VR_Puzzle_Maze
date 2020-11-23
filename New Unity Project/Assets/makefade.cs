using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class makefade : MonoBehaviour
{
    private DateTime starttime;
    private DateTime endtime;

    private Color alphaColor;
    private float timeToFade = 3.0f;
    //Material myRenderer;
    //MeshRenderer myRenderer;
    MeshRenderer myRenderer;
    Color solidcolor;
    void Start(){
        starttime = DateTime.Now;
    }
    void Update()
    {   
        endtime = DateTime.Now;
        if((endtime - starttime).TotalSeconds >= 3f){
            Destroy(gameObject);
        }
         
    }
}
