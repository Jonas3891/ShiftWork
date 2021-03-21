using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour, IInteractable
{
    private Animator _animator;
    private bool isOpen = false;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public void activate()
    {
        if (!isOpen)
        {
            Debug.Log("Door Open");
            _animator.Play("DoorOpen");
            isOpen = true;
        }
        if(isOpen)
        {
            Debug.Log("Door Closing");
            _animator.Play("DoorClose");
            isOpen = false;
        }
    }
    public void interact()
    {
        activate();
    }
}
