using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, IInteractable
{
    private bool isTop = false;
    private bool isBottom = false;

    [SerializeField] public GameObject Elevator;
    public bool canMove = true;
    public bool hasCoroutine = false;

    
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
                this.GetComponentInParent<ElevatorPanelControl>().MoveUp(this.GetComponentInParent<ElevatorPanelControl>().Floor1);
            }
        }

        if (this.name == "ButtonFloor2")
        {
            if (!hasCoroutine && !isTop)
            {
                this.GetComponentInParent<ElevatorPanelControl>().MoveUp(this.GetComponentInParent<ElevatorPanelControl>().Floor2);
            }
        }

        if (this.name == "ButtonFloor3")
        {
            if (!hasCoroutine && !isTop)
            {
                this.GetComponentInParent<ElevatorPanelControl>().MoveUp(this.GetComponentInParent<ElevatorPanelControl>().Floor3);
            }
        }

        if (this.name == "ButtonFloor4")
        {
            if (!hasCoroutine && !isTop)
            {
                this.GetComponentInParent<ElevatorPanelControl>().MoveUp(this.GetComponentInParent<ElevatorPanelControl>().Floor4);
            }
        }

        if (this.name == "ButtonFloor5")
        {
            if (!hasCoroutine && !isTop)
            {
                this.GetComponentInParent<ElevatorPanelControl>().MoveUp(this.GetComponentInParent<ElevatorPanelControl>().Floor5);
            }
        }

        if (this.name == "ButtonFloor6")
        {
            if (!hasCoroutine && !isTop)
            {
                this.GetComponentInParent<ElevatorPanelControl>().MoveUp(this.GetComponentInParent<ElevatorPanelControl>().Floor6);
            }
        }

    }

    public void interact()
    {
        Switch();
    }
}
