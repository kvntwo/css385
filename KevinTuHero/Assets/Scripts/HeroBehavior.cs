using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBehavior : MonoBehaviour
{

     public float speed = 50f;

     public float MouseRotateSpeed = 90f / 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 pos = transform.position;
        
        if (Input.GetKey(KeyCode.W))
        {
            pos += ((speed * Time.smoothDeltaTime) * transform.up;
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos -= ((speed * Time.smoothDeltaTime) * transform.up;
        }

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos; 
    }
}
