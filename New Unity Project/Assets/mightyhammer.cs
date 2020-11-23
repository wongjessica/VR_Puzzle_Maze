using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class mightyhammer : MonoBehaviour
{
    public int boxcount = 3;
    private double time = 0;

    
    void Start(){
        gameObject.layer = 12;
    }

    void Update(){
        if(boxcount == 0){
            time += Time.deltaTime;
            if(time >= 1f){
                Destroy(gameObject);
            }
        }
    }

}
