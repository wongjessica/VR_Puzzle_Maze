using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCorrectSphere3 : MonoBehaviour
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
        if (col.CompareTag ("GreenS"))
        {
            bool_script.zone3_correctness = true;
            Debug.Log("Green ball is in!");
        }
        else
        {
            return;
        }
    }

    void OnTriggerExit (Collider col)
    {
        Debug.Log("Checking sphere color...");
        if (col.CompareTag("GreenS"))
        {
            bool_script.zone3_correctness = false;
            Debug.Log("Green ball is out...");
        }
        else
        {
            return;
        }
    }
}
