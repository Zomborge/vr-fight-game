using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class dead : MonoBehaviour
{
    public score score;
    public UnityEvent death;
    public printscore scoreDisplay;

    public void Update()
    {
        if(score.life <= 0)
        {
            Debug.Log("game over");

            death.Invoke();
            scoreDisplay.ShowFinalScore(score.totalScore);

        }
    }
}
