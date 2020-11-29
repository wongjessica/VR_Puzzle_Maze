using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Color inactive;
    public Color gazedat;
    private MeshRenderer myRenderer;
    //private transform myObj;
    private bool lookedAt = false;
    public GameObject cam;
    private double time = 0;

    public void gazeAt(bool gazing){
        //if pointer on object, sets gazing and lookedat as true
        if (gazing){
            lookedAt = true;
        }
        //else pointer looks away, sets gazing and lookedat as false
        else{
            time = 0;
            lookedAt = false;
            myRenderer.material.color = inactive;
        }
    }
    // Start is called before the first frame update
    void Start(){
        myRenderer = GetComponent<MeshRenderer>();
        //myObj = GetComponent<Transform>();
        myRenderer.material.color = inactive;
    }

    // Update is called once per frame
    void Update(){
        //keeps checking lookedat and if its true, lerp from inactive to gazed
        if (lookedAt){
            myRenderer.material.color = Color.Lerp(myRenderer.material.color,gazedat, Time.deltaTime);
            time += Time.deltaTime;
            if (time >= 2){
                Vector3 telepos = new Vector3(transform.position.x, cam.transform.position.y, transform.position.z);
                cam.transform.position = telepos;
            } 
        }
    }
}
