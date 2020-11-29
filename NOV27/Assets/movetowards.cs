using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class movetowards : MonoBehaviour
{
    public Transform target;
    public float speed = 2f;
    bool moved = false;
    bool raycastdone = false;

    //public printing setPaper; 
    public GameObject printer = null; 
    public GameObject hamma = null;
    //public GameObject paper; 

    // Update is called once per frame
    void Update()
    {   
        RaycastHit hit;
        Vector3 bottomedge = new Vector3(transform.position.x, transform.position.y - .5f, transform.position.z); //where ray will shoot out of
        Vector3 targpos = new Vector3(target.position.x, target.position.y - 1, target.position.z); //target pos, which is like middle of char
        Ray approach = new Ray(bottomedge, target.position - transform.position); //the ray info, from where and what direction
        //Ray approach = new Ray(bottomedge, new Vector3(target.position.x, target.position.y)); //the ray info, from where and what direction
        float step =  speed * Time.deltaTime; // calculate distance to move
        if(!moved){
            if(!raycastdone && Physics.Raycast(approach, out hit, 1f) && hit.collider.tag != "Player"){ //raycast done if it hits nothing
                transform.position = new Vector3(transform.position.x, transform.position.y + step, transform.position.z);
                //DrawRay(bottomedge, hit.point, new Vector3(target.position.x, target.position.y), Color.red); 
                DrawRay(bottomedge, hit.point, transform.position - target.position, Color.red);     
            }
            //float step =  speed * Time.deltaTime; // calculate distance to move   
            else{
                raycastdone = true;
                
                transform.position = Vector3.MoveTowards(transform.position , targpos, step);
            }
        }
    }

    private void OnTriggerEnter(Collider other){
        if (other.tag == "Player" && printer != null){
            Destroy(gameObject);
            printer.layer = 11;
        }
        else if(hamma != null){
            Destroy(gameObject);
            hamma.SetActive(true);
        }
        
        else{
            Destroy(gameObject);
            treasureboxtriggerer.haskey = true;
        }
        
    }
    private void DrawRay(Vector3 origin, Vector3 end, Vector3 direction, Color color){
        Debug.DrawLine(origin,end,color,5);
    }
}
