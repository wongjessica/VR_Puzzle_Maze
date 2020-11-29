using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reveal : MonoBehaviour
{
    // Update is called once per frame
    public Vector3 target;
    void Update()
    {
        if (Vector3.Distance(transform.position, target) > 0.05f){
        }
        else{
            Destroy(gameObject);
        }
    }
}
