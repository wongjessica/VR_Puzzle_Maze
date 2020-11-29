using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CouchTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject sofa_4;

    bool isMoved = false;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player") && !isMoved)
        {
            isMoved = true;
            sofa_4.transform.position += new Vector3(0, 0, 4);
        }
    }
}
