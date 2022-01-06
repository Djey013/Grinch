using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    public MyScriptableObject persistent;
    public Score _sc;
    public Chest _ch;


    public void Update()
    {
        NextLevel();
        GameOver();
        //LifeLost();

    }

    public void NextLevel()
    {
        if (persistent.chested == _sc.maxScore)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


    public void GameOver()
    {
        if (persistent.vie == 0)
        {
            SceneManager.GetActiveScene();
            persistent.chested = 0;
        }

    }

    public void LifeLost()
    {
        //if
        persistent.vie--;
    }


}
