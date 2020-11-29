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
    private GameObject obj1;
    private GameObject obj2;
    private GameObject obj3;
    private GameObject obj4;
    private GameObject obj5;

    void Start()
    {
         obj1 = GameObject.Find("Blue Sphere");
         obj2 = GameObject.Find("Orange Sphere");
         obj3 = GameObject.Find("Green Sphere 1");
         obj4 = GameObject.Find("Green Sphere 2");
         obj5 = GameObject.Find("Yellow Sphere");
    }

    public void Update()
    {
        if ((obj1.transform.position.z > obj2.transform.position.z) && (obj2.transform.position.z > obj3.transform.position.z)
        && ((obj3.transform.position.z > obj4.transform.position.z) || (obj4.transform.position.z > obj3.transform.position.z))&& (obj4.transform.position.z >obj5.transform.position.z)
)
        {
            Debug.Log("Puzzle solved!");
            anim.SetBool("Open", true);
            return;
        }
    }

}
