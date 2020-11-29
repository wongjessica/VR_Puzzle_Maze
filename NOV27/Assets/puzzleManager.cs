using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleManager : MonoBehaviour
{
    public Transform[] pictures;

    public static bool Win;
   

    // Update is called once per frame
    void Update(){
        if(pictures[0].rotation.z == 0 && pictures[1].rotation.z == 0 && pictures[2].rotation.z == 0 && pictures[3].rotation.z == 0 && pictures[4].rotation.z == 0 && pictures[5].rotation.z == 0){
            Win = true;
            Debug.Log("won");
            this.enabled = false;
        }
    }
}
