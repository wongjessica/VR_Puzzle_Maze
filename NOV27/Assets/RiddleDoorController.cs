using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RiddleDoorController : MonoBehaviour 
{

    // Start is called before the first frame update

    bool random = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       // doorCheck();
    }

    
    public void doorCheck()
    {

        transform.Rotate(0, 0, 90);


    }

}
