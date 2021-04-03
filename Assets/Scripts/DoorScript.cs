using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour, IInteractable
{
    private Animator _animator;
    private bool isOpen = false;
    private bool isPlaying = false;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public void activate()
    {
        if (!isOpen)
        {
           _animator.Play("DoorOpen");
            isOpen = true;
        }

        if(isOpen)
        {
            _animator.Play("DoorClose");
            isOpen = false;
        }
    }
    public void interact()
    {
        Debug.Log(!isPlaying);
        if (!isPlaying)
        {
            Debug.Log("In animation");
            StartCoroutine(playAnimation());
        }
    }

    public IEnumerator playAnimation()
    {
        isPlaying = true;
        Debug.Log("In inumerator");
        if (isOpen)
        {
            Debug.Log("Close");
            _animator.Play("DoorClose");
            isOpen = false;
        }
        else if (!isOpen)
        {
            Debug.Log("open");
            _animator.Play("DoorOpen");
            isOpen = true;
        }

        yield return new WaitForSeconds(2f);
        isPlaying = false;

    }
}
