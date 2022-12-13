using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scores : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    public static int count;
    public static int hiscore;
// These are the changes that will be shown in github

    private void Update()
    {
        if (scoreText != null)
        {
            scoreText.text = $"Score: {count}";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Player.run)
        {
            count += 1;
            Debug.Log(count);
        }
        if (count > hiscore)
        {
            hiscore = count;
        }
    }
}
