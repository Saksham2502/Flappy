using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipes : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] float time = 10f;
    [SerializeField] float speed;
    float currTime;
   
   

    
    void FixedUpdate()
    {
        Vector3 sp = new Vector3(-speed * Time.deltaTime, 0, 0);
        transform.position += sp;
        if(currTime>= time)
        { 
            float ran = Random.Range(-7.24f, -2.04f);
            Vector3 position = new Vector3(12.83f, ran, 0);
            Instantiate(pipe, position, transform.rotation);
            currTime = 0;
        }
        
        else
        {
            currTime += Time.fixedDeltaTime;
        }
        
    }
    
}
