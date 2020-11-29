using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabObject : MonoBehaviour
{
    public GameObject barrel;
    public GameObject hands;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clicked(){
        barrel.transform.SetParent(hands.transform);
        barrel.transform.localPosition = new Vector3(0f, -.672f, 0f);
    }
}
