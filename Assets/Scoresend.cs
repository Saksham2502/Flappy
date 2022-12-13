using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoresend : MonoBehaviour
{
    [SerializeField] Text scoreText;
    //public static int count;
   // public static int hiscore;
    // These are the changes that will be shown in github

    private void Update()
    {
        if (scoreText != null)
        {
            scoreText.text = $"Score: {Scores.count}";
        }
    }

    
}
