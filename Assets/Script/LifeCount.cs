using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
    public MyScriptableObject persistent;
    public Text board3;


    public void ChestBoard()
    {
        board3.text = " " + persistent.vie;

        if (persistent.chested <= 1)
        {
            board3.color = Color.red;               
        }
    }


}
