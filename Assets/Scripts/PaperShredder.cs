using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperShredder : MonoBehaviour
{
    private int Score = 0; 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if (other.gameObject.tag == "Paper")
        {
            Debug.Log("Destorying Paper Object");
            Destroy(other.gameObject);
            Score += 1;
            Debug.Log("Score is: " + Score);
        }
    }
}
