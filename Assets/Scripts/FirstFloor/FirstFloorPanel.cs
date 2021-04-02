using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFloorPanel : MonoBehaviour
{
    public GameObject buttonUp;
    public GameObject buttonDown;
    public GameObject Elevator_buttonUp;
    public GameObject Elevator_buttonDown;
    public Material on;
    public Material off;

    // Start is called before the first frame update
    void Start()
    {
        buttonUp.GetComponent<Renderer>().material = off;
        buttonDown.GetComponent<Renderer>().material = off;
        Elevator_buttonUp.GetComponent<Renderer>().material = off;
        Elevator_buttonDown.GetComponent<Renderer>().material = off;
        EndTrigger.OnEndTrigger += lvlComplete;
    }

    void lvlComplete()
    {
        Debug.Log("lvlComplete in PaneControl");
        buttonUp.GetComponent<Button>().canMove = true;
        buttonDown.GetComponent<Button>().canMove = true;
        Elevator_buttonUp.GetComponent<Button>().canMove = true;
        Elevator_buttonDown.GetComponent<Button>().canMove = true;


        buttonUp.GetComponent<Renderer>().material = on;
        buttonDown.GetComponent<Renderer>().material = on;
        Elevator_buttonUp.GetComponent<Renderer>().material = on;
        Elevator_buttonDown.GetComponent<Renderer>().material = on;


    }
}