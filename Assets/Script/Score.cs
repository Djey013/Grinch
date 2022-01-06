using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    

    public Text board;
    public int catched = 0;
    public int maxScore = 6;
    

    public void Update()
    {
        ScoreBoard();
        
    }

    public void ScoreBoard()
    {
        board.text = " " + catched;
    }
   
    


}
