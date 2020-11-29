using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool locked;

    public Animator anim;

    public void OpenClose()
    {
        if (locked)
        {
            Debug.Log("Locked by password");
            return;
        }

        anim.SetBool("Open", true);
    }

}
