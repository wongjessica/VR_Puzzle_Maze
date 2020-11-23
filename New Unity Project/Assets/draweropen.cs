using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draweropen : MonoBehaviour
{
    bool isOpened;
    public Animator draweranimator;
    public void openOrClose(){
        if(!isOpened){
            draweranimator.SetBool("opened", true);
            isOpened = true;
        }
        else{
            draweranimator.SetBool("opened", false);
            isOpened = false;
        }
    }
}
