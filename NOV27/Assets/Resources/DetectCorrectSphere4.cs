using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCorrectSphere4 : MonoBehaviour
{
    public GameObject the_door;
    private DoorController2 bool_script;

    private void Start()
    {
        Debug.Log("Here we are, at start");
        bool_script = the_door.GetComponent<DoorController2>();
    }

    void OnTriggerEnter (Collider col)
    {
        Debug.Log("Checking sphere color...");
        if (col.CompareTag ("YellowS"))
        {
            bool_script.zone5_correctness = true;
            Debug.Log("Yellow ball is in!");
        }
        else
        {
            return;
        }
    }

    void OnTriggerExit (Collider col)
    {
        Debug.Log("Checking sphere color...");
        if (col.CompareTag("YellowS"))
        {
            bool_script.zone1_correctness = false;
            Debug.Log("Yellow ball is out...");
        }
        else
        {
            return;
        }
    }
}
