using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameObject player;
    public Rigidbody2D rb;
    [SerializeField]  float speed;
    Vector3 sp;
    [SerializeField] float force;
    public static bool run;
    void Start()
    {
      sp= new Vector3(speed * Time.deltaTime, 0, 0);
        rb = GetComponent<Rigidbody2D>();
        run = true;
        Scores.count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += sp;
        if (Input.GetKeyDown(KeyCode.W)&& run)
        {
            //rb.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
            rb.velocity += new Vector2(0, force);
        }
        
    }
}
