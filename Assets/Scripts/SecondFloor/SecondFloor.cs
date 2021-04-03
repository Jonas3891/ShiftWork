using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SecondFloor : MonoBehaviour
{
    public Text scoreDisplay;
    private int Score = 0;
    private int MAXSCORE = 5;

    public delegate void lvlComplete();
    public static event lvlComplete OnComplete;

    private void Start()
    {
        scoreDisplay.enabled = true;
    }
    private void OnEnable()
    {
        Debug.Log("Enabled Floor 2");
        PaperShredder.OnShred += shredder;
        EnterFloor.OnEnter += StartFloor;
    }

    private void OnDisable()
    {
        PaperShredder.OnShred -= shredder;
    }

    void StartFloor()
    {
        Debug.Log("Starting Second Floor");
    }
    void shredder()
    {
        Score += 1;
        scoreDisplay.text = Score.ToString() + "/" + MAXSCORE;

        if(Score >= MAXSCORE)
        {
            winCondition();
        }
    }

    void winCondition()
    {
        Debug.Log(Score);
        Debug.Log(MAXSCORE);
        OnComplete();
    }
}