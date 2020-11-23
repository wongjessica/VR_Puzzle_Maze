﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

using System;

public class Rotate : MonoBehaviour, IPointerClickHandler
{
    public static event Action<string, int> Rotated = delegate { };
    private bool coroutineAllowed;
    private int numberShown;
    
    void Start(){
        coroutineAllowed = true;
        numberShown = 0;
    }

    public void OnPointerClick(PointerEventData pointerEventData) {
        if (coroutineAllowed){
            StartCoroutine("RotateWheel");
        }
    }

    private IEnumerator RotateWheel(){
        coroutineAllowed = false;

        for (int i = 0; i <= 11; i++){
            transform.Rotate(0f, 3f, 0f);
            yield return new WaitForSeconds(0.01f);
        }

        coroutineAllowed = true;
        numberShown += 1;

        if (numberShown > 9){
            numberShown = 0;
        }
        Rotated(name, numberShown);
    }
}
