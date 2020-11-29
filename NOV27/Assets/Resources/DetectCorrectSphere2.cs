using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCorrectSphere2 : MonoBehaviour
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
        if (col.CompareTag ("OrangeS"))
        {
            bool_script.zone2_correctness = true;
            Debug.Log("Orange ball is in!");
        }
        else
        {
            return;
        }
    }

    void OnTriggerExit (Collider col)
    {
        Debug.Log("Checking sphere color...");
        if (col.CompareTag("OrangeS"))
        {
            bool_script.zone2_correctness = false;
            Debug.Log("Orange ball is out...");
        }
        else
        {
            return;
        }
    }
}
