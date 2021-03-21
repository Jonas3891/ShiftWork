using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    private bool isTopFloor = false;
    private bool isBottomFloor = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Final_floor")
        {
            Debug.Log("IsTop is Now: True");
            isTopFloor = true;
        }
        if(other.tag == "Bottom_floor")
        {
            Debug.Log("IsBottom is Now: True");
            isBottomFloor = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Final_floor")
        {
            Debug.Log("isTop is now: False");
            isTopFloor = false;
        }
        if (other.tag == "Bottom_floor")
        {
            Debug.Log("IsBottom is Now: False");
            isBottomFloor = false;
        }
    }

    public bool isBottom()
    {
        return isBottomFloor;
    }
    public bool isTop()
    {
        return isTopFloor;
    }
}
