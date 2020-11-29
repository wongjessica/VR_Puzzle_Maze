using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCorrectSphere : MonoBehaviour
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
        if (col.CompareTag ("BlueS"))
        {
            bool_script.zone1_correctness = true;
            Debug.Log("Blue ball is in!");
        }
        else
        {
            return;
        }
    }

    void OnTriggerExit (Collider col)
    {
        Debug.Log("Checking sphere color...");
        if (col.CompareTag("BlueS"))
        {
            bool_script.zone1_correctness = false;
            Debug.Log("Blue ball is out...");
        }
        else
        {
            return;
        }
    }
}
