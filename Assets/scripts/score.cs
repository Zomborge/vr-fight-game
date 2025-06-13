using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class score : MonoBehaviour
{
    
    static public float totalScore = 0;
    static public float combo = 1;
    static public float life = 10;
    static public float boldur = 0;

    public void OnPointGain()
    {
        totalScore += 1 * (combo/100);
        Debug.Log(totalScore);
        combo += 1;
    }
    public void ComboLoss()
    {
        
        combo = 0;
        life -= 1;
        Debug.Log(life);
        
    }
    public void boldo_down()
    {
        boldur += 1;
        totalScore += 1000 * (combo / 100);
        if (boldur == 3)
        {
            life = 0;
        }
    }
}
