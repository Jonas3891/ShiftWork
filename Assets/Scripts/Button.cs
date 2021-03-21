using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, IInteractable
{
    private bool isTop = false;
    private bool isBottom = false;
    public GameObject targetPosition;
    [SerializeField] public GameObject Elevator = null;
    
    private bool hasCoroutine = false;
    void Start()
    {
        isTop = Elevator.GetComponent<EventTrigger>().isTop();
        isBottom = Elevator.GetComponent<EventTrigger>().isBottom();
    }
    public void Switch()
    {
        isTop = Elevator.GetComponent<EventTrigger>().isTop();
        isBottom = Elevator.GetComponent<EventTrigger>().isBottom();
        if (this.name == "Button up")
        {
            if (!hasCoroutine && !isTop)
            {
                MoveUp();
                isTop = Elevator.GetComponent<EventTrigger>().isTop();
                isBottom = Elevator.GetComponent<EventTrigger>().isBottom();
            }
        }
        if (this.name == "Button down")
        {

            if (!hasCoroutine && !isBottom)
            {
                MoveDown();
                isTop = Elevator.GetComponent<EventTrigger>().isTop();
                isBottom = Elevator.GetComponent<EventTrigger>().isBottom();
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
        Switch();
    }
}
