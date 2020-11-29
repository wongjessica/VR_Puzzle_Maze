using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoWalk : MonoBehaviour
{
    public Transform vrCamera;
    public float toggleAngle = 10;
    public float speed = 4;
    public bool moveForward = false;
    public bool touchingObj = false;
    
    [SerializeField]private AudioClip[] walkClips;
    private CharacterController cc;
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            moveForward = !moveForward;
        }

        if(moveForward){
            if(vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f){
                Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
                cc.SimpleMove(forward * speed);
                if(audioSource.isPlaying == false && cc.isGrounded == true){
                    AudioClip walkClip;
                    walkClip = walkClips[UnityEngine.Random.Range(0, walkClips.Length)];

                    audioSource.PlayOneShot(walkClip);
                }
            }
        }
    }
    /**
    public void entered(){
        touchingObj = true;
    }
    public void exited(){
        touchingObj = false;
    }
    */
}
