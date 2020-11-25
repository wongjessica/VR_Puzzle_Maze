using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
public class finalpuzzleManager : MonoBehaviour
{
    //private int[] result, correct;

    public int[,] result;
    public int[,] correct;


    private bool isSolved;
    
    //public Animator openLock;
    //public Animator openDoor;
    void Start(){
        result = new int[,]
        {   
            {0,0,0},
            {0,0,0},
            {0,0,0}
        };

        correct = new int[,]
        {   {0,1,0},
            {1,0,1},
            {0,1,0}
        };

        isSolved = false;
        Activate.Activated += CheckResults;
    }

    private void CheckResults(string objName, int number){
        switch (objName){
            case "One":
                result[0,0] = number;
                break;

            case "Two":
                result[0,1] = number;
                break;

            case "Three":
                result[0,2] = number;
                break;
            case "Four":
                result[1,0] = number;
                break;

            case "Five":
                result[1,1] = number;
                break;

            case "Six":
                result[1,2] = number;
                break;
            case "Seven":
                result[2,0] = number;
                break;

            case "Eight":
                result[2,1] = number;
                break;

            case "Nine":
                result[2,2] = number;
                break;
            
        }
        
        if(!isSolved){
            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    if((i+j) % 2 == 1 && result[i,j] != 1){ 
                        return;
                    }
                    if((i+j) % 2 == 0 && result[i,j] != 0){
                        return;
                    }
                }
            }
        }
        isSolved = true;
    }
    
}
*/

public class finalpuzzleManager : MonoBehaviour
{
    //private int[] result, correct;

    private int[] result;
    private int[] correct;

    public Activate[] activations;

    private bool isSolved;
    
    //public Animator openLock;
    //public Animator openDoor;

    public static bool begincountdown;
    public float maxTime = 30f;
    
    void Start(){
        result = new int[]{0,0,0,0,0,0,0,0,0};

        correct = new int[]{0,1,0,1,0,1,0,1,0};

        isSolved = false;
        Activate.Activated += CheckResults;
    }
    void Update(){
        if( !isSolved && begincountdown){
            maxTime-= Time.deltaTime;
            if(maxTime <= 3){   //make them uninteractable before we reset animation so we dont have anim playing right before resetting animation
                foreach(Activate resetEm in activations){
                    resetEm.TimesUp();
                }
                foreach(int i in result) {
                    result[i] = 0;  //reset the results
                }
            }
            if(maxTime <= 2){
                foreach(Activate resetEm in activations){
                    resetEm.ResetAnimation(); //reset the animation
                }
            }
            if(maxTime <= 0){
                foreach(Activate resetEm in activations){
                    resetEm.Reset();    //make back interactable
                }
                begincountdown = false;     //countdown will start again if object touched
                maxTime = 30f;  //reset countdown
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
        if(!isSolved){
            for(int i = 0; i < 9; i++){
                if(i % 2 == 0 && result[i] != 0) return;
                else if(i % 2 == 1 && result[i] != 1) return;
            }
        }
        isSolved = true;
        foreach(Activate resetEm in activations){
            resetEm.enabled = false;    //make back interactable
        }
        this.enabled = false;
        Debug.Log("open behind");
    }
    
}