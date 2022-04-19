using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    public MyScriptableObject persistent;
    public CountDown _countDown;
    public GameObject grinch;
    
    public Score _sc;
    public Chest _ch;
    public GameObject gameOverMessage;


    public void Update()
    {
        NextLevel();
        GameOver();
        StartCoroutine(TimeUp());

    }

    public void NextLevel()
    {
        if (persistent.chested == _sc.maxScore)
        {
            persistent.chested = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    

    IEnumerator TimeUp()
    {
        if (_countDown.timeRemaining == 0)
        {
            Debug.Log("Time up...");
            //grinch.GetComponent<BoxCollider>().enabled = false;
            
            yield return new WaitForSeconds(1f);
            gameOverMessage.SetActive(true);
            persistent.chested = 0;
            
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene(0);
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


}
