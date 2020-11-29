using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController2 : MonoBehaviour
{
    public bool zone1_correctness = false;
    public bool zone2_correctness = false;
    public bool zone3_correctness = false;
    public bool zone4_correctness = false;
    public bool zone5_correctness = false;
    public Animator anim;


    public void Update()
    {
        if ((zone1_correctness == true) && (zone2_correctness == true)
        && (zone3_correctness == true) && (zone4_correctness == true)
        && (zone5_correctness == true))
        {
            Debug.Log("Puzzle solved!");
            anim.SetBool("Open", true);
            return;
        }
    }

}
