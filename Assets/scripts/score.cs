using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    static public float totalScore = 0;
    static public float combo = 1;

    public void OnPointGain()
    {
        totalScore += 1 * (combo/100);
        Debug.Log(totalScore);
        combo += 1;
    }
    public void ComboLoss()
    {
        combo = 0;
    }
}
