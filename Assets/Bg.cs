using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bg : MonoBehaviour
{
    [SerializeField] GameObject bg;
    [SerializeField]GameObject marker;
    [SerializeField] float speed;
    bool spawn;
    float scwidth;
    float scheight;
    //Vector3 sp;
    Vector3 newp;
    void Start()
    {
        spawn = true;
        scheight = Camera.main.orthographicSize * 2;
        scwidth = scheight * Camera.main.aspect;
        //sp = new Vector3(-speed, 0, 0);
        newp = new Vector3(scwidth, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(marker.transform.position.x < scwidth/2 && spawn)
        {
           Instantiate(bg, newp, transform.rotation);
            spawn = false;
        }
        if(marker.transform.position.x < -scwidth / 2)
        {
            Destroy(this.gameObject);
            spawn = true;
        }
        transform.position += new Vector3(-speed*Time.deltaTime,0,0);
    }
}
