using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperShredder : MonoBehaviour
{
    public Text scoreDisplay; 

    private int Score = 0; 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if (other.gameObject.tag == "Paper")
        {
            Debug.Log("Destorying Paper Object");
            Destroy(other.gameObject);
            Score += 1;
            DisplayScore(Score); 
            Debug.Log("Score is: " + Score);
        }
    }

    void DisplayScore(int curScore)
    {
            scoreDisplay.text = curScore.ToString();
    }
}
