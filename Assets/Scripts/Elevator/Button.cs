using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, IInteractable
{
    private bool isTop = false;
    private bool isBottom = false;
    private bool isBusy = false;
    public GameObject targetPosition;
    [SerializeField] public GameObject Elevator = null;
    public bool canMove = false;
    public bool hasCoroutine = false;

    void Start()
    {
 
        isTop = Elevator.GetComponent<EventTrigger>().isTop();
        isBottom = Elevator.GetComponent<EventTrigger>().isBottom();
        hasCoroutine = Elevator.GetComponent<MoveObject>().isButtonLocked();
    }
    public void Switch()
    {
        isTop = Elevator.GetComponent<EventTrigger>().isTop();
        isTop = Elevator.GetComponent<EventTrigger>().isTop();
        isBottom = Elevator.GetComponent<EventTrigger>().isBottom();
        hasCoroutine = Elevator.GetComponent<MoveObject>().isButtonLocked();
        if (this.name == "Button up")
        {
            if (!hasCoroutine && !isTop)
            {
                hasCoroutine = true;
                MoveUp();
                isTop = Elevator.GetComponent<EventTrigger>().isTop();
                isBottom = Elevator.GetComponent<EventTrigger>().isBottom();
                hasCoroutine = false;
            }
        }
        if (this.name == "Button down")
        {

            if (!hasCoroutine && !isBottom)
            {
                hasCoroutine = true;
                MoveDown();
                isTop = Elevator.GetComponent<EventTrigger>().isTop();
                isBottom = Elevator.GetComponent<EventTrigger>().isBottom();
                hasCoroutine = false;
            }
        }
    }

    private void MoveUp()
    {
        StartCoroutine(Elevator.GetComponent<MoveObject>().SmoothLerp(3f, Elevator, targetPosition));
    }
    private void MoveDown()
    {
        StartCoroutine(Elevator.GetComponent<MoveObject>().SmoothLerp(3f, Elevator, targetPosition));
    }
    public void interact()
    {
        if (canMove)
        {
            Switch();
        }
    }
}
