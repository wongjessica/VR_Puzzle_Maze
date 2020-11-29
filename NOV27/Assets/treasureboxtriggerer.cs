using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureboxtriggerer : MonoBehaviour
{
    public static bool haskey = false;
    public Animator treasurebox;
    public void playAnimonKey(){
        if(haskey){
            treasurebox.SetBool("hasKey", true);
        }
    }
}
