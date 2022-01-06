using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float timeRemaining = 60f;
    public float timeUp = 0f;
    public Text timerBoard;

    private void Start()
    {
        
    }

    void Update()
    {
        timeRemaining -= 1 * Time.deltaTime;            // -= 1 permet d'enlever 1 unité à timeRemaining mais 1 unité en seconde grace à Time.deltaTime

        timerBoard.text = timeRemaining.ToString("0"); //ToString permet de convertir le type "float" de timeRemaining et d'eviter une erreur de la console
                                                       //il permet également l'obligation de mettre un texte " " + ... au début, avant l'implémentation de timeRemaining
                                                       //("0") permet d'afficher seulement un nombre entier au lieu d'un nombre à virgule.

        

        if (timeRemaining <= timeUp)
        {
            timeRemaining = 0;                          // évite au timer de passer en dessous de 0
        }

        if (timeRemaining <= 30)
        {
            timerBoard.color = Color.yellow;            // change la couleur du timer en jaune quand arrivé à 30 secondes
        }

        if (timeRemaining <= 10)
        {
            timerBoard.color = Color.red;               
        }

        

    }


}
