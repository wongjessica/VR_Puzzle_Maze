using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class makefade : MonoBehaviour
{
    private float time;
    private Color alphaColor;
    //private float timeToFade = 3.0f;

    Material myRenderer;
    private float smoothness = .75f;

    Color solidcolor;
    void Start(){
        myRenderer = gameObject.GetComponent<MeshRenderer>().material;
        alphaColor.a = 0;
    }
    void Update()
    {   
        time+= Time.deltaTime;
        myRenderer.color = Color.Lerp(myRenderer.color, alphaColor, smoothness * Time.deltaTime);
        if(time >= 3f){
            Destroy(gameObject);
        }
         
    }
}
