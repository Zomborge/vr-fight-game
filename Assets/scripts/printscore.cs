using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class printscore : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreText;
    private void Start()
    {
        scoreText.gameObject.SetActive(false);
    }
    public void ShowFinalScore(float finalScore)
    {
        // Update the text with the final score.
        scoreText.text = "Final Score: " + finalScore.ToString();

        // Enable the text box so the player sees it.
        scoreText.gameObject.SetActive(true);
    }
}
