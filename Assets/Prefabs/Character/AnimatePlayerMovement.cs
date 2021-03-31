using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePlayerMovement : MonoBehaviour
{
    public Animator anim;       // Plays the animations for the character
    public GameObject fist;     // References the mesh for onCollisions
    public GameObject player;  
    float speed; 
    CharacterController characterController;
    public bool hasPunched = false; 

    public void Start()
    {
        // Gets the controller so that it can update the player speed used in the walk/run animation
        characterController = player.GetComponent<CharacterController>();

        // Disable meshh collider so fist does not destruct objects by accident
        fist.GetComponent<MeshCollider>().enabled = false;
    }
    private void Update()
    {
        // Set the walk speed that is used by the walk/run animator
        speed = characterController.GetComponent<HeroMovement>().curSpeedX;
        anim.SetFloat("walk", speed);


        // Plays the punching animation of the player. 
        if (Input.GetMouseButtonDown(0))
        {
             // Enable the mesh collider so it can register a hit
            fist.GetComponent<MeshCollider>().enabled = true;
            hasPunched = true;
            anim.SetTrigger("Punch");
            hasPunched = false;
            fist.GetComponent<MeshCollider>().enabled = false;
        }
    }

    IENumerator Routine()
    {
        // play the animation

        while (!animationDone)
            yield return new WaitForEndOfFrame();

        // 
    }
