using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class audioscript : MonoBehaviour {
    [SerializeField]
    private AudioClip[] walkClips;
    
    private AudioSource audioSource;

    CharacterController cc;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       if (cc.isGrounded == true && cc.velocity.magnitude <= 3f && audioSource.isPlaying == false) 
       {
              AudioClip walkClip;
              walkClip = walkClips[UnityEngine.Random.Range(0, walkClips.Length)];

              audioSource.PlayOneShot(walkClip);
        }
        
    }
}