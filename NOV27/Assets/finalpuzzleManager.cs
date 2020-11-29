using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalpuzzleManager : MonoBehaviour
{
    private int[] result;
    private int[] correct;

    public Activate[] activations;

    private bool isSolved;
    
    public Animator rise;
    public Reveal destroyscript;

    public static bool begincountdown;
    public float maxTime;
    
    public float temptime;
    public AudioSource instance = null;
    public AudioClip rising;
    void Start(){
        result = new int[]{0,0,0,0,0,0,0,0,0};

        correct = new int[]{0,1,0,1,0,1,0,1,0};

        isSolved = false;
        Activate.Activated += CheckResults;
        instance = GetComponent<AudioSource>();
        temptime = maxTime;
    }
    void Update(){
        if( !isSolved && begincountdown){
            maxTime-= Time.deltaTime;
            if(maxTime <= 5){   //make them uninteractable before we reset animation so we dont have anim playing right before resetting animation
                foreach(Activate resetEm in activations){
                    resetEm.TimesUp();
                }
            }
            if(maxTime <= 2.5){
                foreach(Activate resetEm in activations){
                    resetEm.ResetAnimation(); //reset the animation
                }
                result[0] = 0; 
                result[1] = 0;
                result[2] = 0;
                result[3] = 0;
                result[4] = 0;
                result[5] = 0;
                result[6] = 0;
                result[7] = 0;
                result[8] = 0;
            }
            if(maxTime <= 0){
                foreach(Activate resetEm in activations){
                    resetEm.Reset();    //make back interactable
                }
                begincountdown = false;     //countdown will start again if object touched
                maxTime = temptime;  //reset countdown
            }
        }
    }
    private void CheckResults(string objName, int number){
        switch (objName){
            case "One":
                result[0] = number;
                break;

            case "Two":
                result[1] = number;
                break;

            case "Three":
                result[2] = number;
                break;
            case "Four":
                result[3] = number;
                break;

            case "Five":
                result[4] = number;
                break;

            case "Six":
                result[5] = number;
                break;
            case "Seven":
                result[6] = number;
                break;

            case "Eight":
                result[7] = number;
                break;

            case "Nine":
                result[8] = number;
                break;
            
        }
        if(!isSolved && result[0] == 0 && result[1] == 1 && result[2] == 0 && result[3] == 1 && result[4] == 0 && result[5] == 1 && result[6] == 0 && result[7] == 1 ){
            isSolved = true;
            foreach(Activate resetEm in activations){
                resetEm.enabled = false;    //make back interactable
            }
            this.enabled = false;

            rise.SetBool("finished", true); //open hidden thing
            destroyscript.enabled = true;
            instance.PlayOneShot(rising);
            Debug.Log("open behind");
        }
    
    }
    
    
}