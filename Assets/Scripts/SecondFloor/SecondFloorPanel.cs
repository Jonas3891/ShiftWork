using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondFloorPanel : MonoBehaviour
{
    public GameObject button;
    public Material on;
    public Material off;

    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<Renderer>().material = off;
        SecondFloor.OnComplete += lvlComplete;
    }

    void lvlComplete()
    {
        Debug.Log("lvlComplete in PaneControl");
        button.GetComponent<Button>().canMove = true;


        button.GetComponent<Renderer>().material = on;


    }
}