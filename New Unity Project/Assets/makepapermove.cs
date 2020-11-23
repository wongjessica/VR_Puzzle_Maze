using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makepapermove : MonoBehaviour
{
    public GameObject paper;
    bool activated;
    
    public void activatePaper(){
        if(!activated){
            paper.SetActive(true);
            activated = true;
        }
    }
}
