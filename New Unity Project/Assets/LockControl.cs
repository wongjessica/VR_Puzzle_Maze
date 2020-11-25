using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockControl : MonoBehaviour
{
    private int[] result, correctCombination;
    private bool isOpened;
    
    public Animator openLock;
    public Animator openDoor;
    void Start(){
        result = new int[]{0,0,0};
        correctCombination = new int[] {4,7,2};
        isOpened = false;
        Rotate.Rotated += CheckResults;
    }

    private void CheckResults(string wheelName, int number){
        switch (wheelName){
            case "WheelOne":
                result[0] = number;
                break;

            case "WheelTwo":
                result[1] = number;
                break;

            case "WheelThree":
                result[2] = number;
                break;
            /**
            case "WheelFour":
                result[3] = number;
                break;
                */
        }

        if (result[0] == correctCombination[0] && result[1] == correctCombination[1]
            && result[2] == correctCombination[2] && !isOpened){
            //transform.position = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
            openLock.SetBool("opened", true);
            isOpened = true;
        }
    }

    public void lockCracked(){
        openDoor.SetBool("opened", true);
    }
    private void OnDestroy(){
        Rotate.Rotated -= CheckResults;
    }
}
