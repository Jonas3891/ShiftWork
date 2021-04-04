using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, IInteractable
{
    private bool isTop = false;
    private bool isBottom = false;
    public GameObject Floor1;
    [SerializeField] public GameObject Elevator;
    public bool canMove = true;
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

        
        if (this.name == "ButtonFloor1")
        {
            if (!hasCoroutine && !isTop)
            {
                MoveUp(Floor1);
            }
        }



        if (this.tag == "Button_down")
        {

            if (!hasCoroutine && !isBottom)
            {
                hasCoroutine = true;
                //MoveDown();
                isTop = Elevator.GetComponent<EventTrigger>().isTop();
                isBottom = Elevator.GetComponent<EventTrigger>().isBottom();
                hasCoroutine = false;
                
            }
        }
    }
    private void MoveUp(GameObject targetPos)
    {
        hasCoroutine = true;
        StartCoroutine(Elevator.GetComponent<MoveObject>().SmoothLerp(3f, Elevator, targetPos));
    }
    private void MoveDown(GameObject targetPos)
    {
        hasCoroutine = true;
        StartCoroutine(Elevator.GetComponent<MoveObject>().SmoothLerp(3f, Elevator, targetPos));
        hasCoroutine = false;
    }

    private void CloseDoors()
    {
        hasCoroutine = true;
        StartCoroutine(Elevator.GetComponent<ElevatorDoors>().CloseElevator());

    }

    private void OpenDoors()
    {
        hasCoroutine = true;
        StartCoroutine(Elevator.GetComponent<ElevatorDoors>().OpenElevator());
        hasCoroutine = false;
    }
    public void interact()
    {
        Debug.Log("triggered Button");
        Switch();
    }
}
