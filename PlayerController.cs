using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    int score;
    public Text ScoreBoard;

    // Use this for initialization
    void Start () {
        score = 0;
        SetScoreBoardText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Add point for putting the item in the goal
    internal void AddPoint()
    {
        score++;
        SetScoreBoardText();
    }

    //Set ScoreBoard Text
    void SetScoreBoardText ()
    {
        if (score < 6)
        {
            ScoreBoard.text = "Score: " + score.ToString();
        }
        else
        {
            ScoreBoard.text = "YOU WIN!!!";
        }
    }
}
