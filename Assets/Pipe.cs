using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pipe : MonoBehaviour
{
    [SerializeField]float speed= 2f;
    float scwidth;
    float scheight;
    [SerializeField] GameObject marker;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player.run = false;
        Debug.Log("high score is"+Scores.hiscore);
        Invoke("reload", 2);
    }
    void reload()
    {
        SceneManager.LoadScene("Gameover");
    }
    private void Start()
    {
        float scheight = Camera.main.orthographicSize * 2;
        float scwidth = scheight * Camera.main.aspect;
    }
     
    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        if (marker.transform.position.x < ((-scwidth / 2) - 9))
        {
            Destroy(this.gameObject);

        }
    }
}
