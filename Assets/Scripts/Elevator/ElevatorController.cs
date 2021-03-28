using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    private void Start()
    {
        GameEvents.current.onDoorWayTriggerEnter += OnDoorwayOpen;
    }

    private void OnDoorwayOpen()
    {
        Debug.Log("In Elevator Controller");
        this.GetComponent<Button>().canMove = true;
    }
}
