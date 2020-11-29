using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
public class destructible : MonoBehaviour
{
    public GameObject destroyedVers;
    public mightyhammer decrement;
    public float bForce = 1f;
    protected Rigidbody rb;
    public AudioManager instance;
    //public Material formakefade;
    private int active = 0;
    Vector3 starttrans;
    void Start(){
        rb = GetComponent<Rigidbody>();
    }


    /**
    public void OnPointerClick(PointerEventData PointerEventData){
        var instantiatedbox = Instantiate(destroyedVers, transform.position, transform.rotation);
        instantiatedbox.AddComponent<makefade>();
        Destroy(gameObject);
        foreach (Transform child in instantiatedbox.transform)
        {   
            child.tag = "breakable";
        }
    }
    */
    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == "hammer"){
            if (rb.velocity.magnitude > bForce && active == 0){
                decrement.boxcount--;
                active++;
                var instantiatedbox = Instantiate(destroyedVers, transform.position, transform.rotation);
                //rb.AddExplosionForce(10f, Vector3.zero, 0f);
                instance.Play("wood1");
                Destroy(gameObject);
                //instantiatedbox.AddComponent<makefade>();
                //instantiatedbox.GetComponent<MeshRenderer>().material = formakefade;
                foreach (Transform child in instantiatedbox.transform)
                {   
                    child.gameObject.AddComponent<makefade>();

                    child.tag = "breakable";
                }
            }
        }
    }
    
}
