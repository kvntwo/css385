using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroBehavior : MonoBehaviour
{
    public Text EnemyCountText = null;
    public Text EggText = null;

    private int eggCount = 0;

    private GameObject EC;
 
    public float speed = 50f;
    public float HeroRotateSpeed = 90f / 2;

    public bool FollowMouse = true;

    private float shotCD = 0.2f;
    private float nextShot = 0f;

    private int planesTagged = 0;
    private GameControllerBehavior heroGC = null;

    // Start is called before the first frame update
    void Start()
    {
        EggText.text = "Eggs on Screen: 0";
        EnemyCountText.text = "Planes Tagged: 0";
        heroGC = FindObjectOfType<GameControllerBehavior>();

    }

    // Update is called once per frame
    void Update()
    {
       
        //Switches movement from WASD to mouse
        if(Input.GetKeyDown(KeyCode.M))
        {

            FollowMouse = !FollowMouse;

        }

        Vector3 pos = transform.position;

        //Switch movement to follow mouse after 'M' has been pressed
        if(FollowMouse)
        {
            pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0f;

        }
        else
        {
            
            if(Input.GetKey(KeyCode.W))
            {
                pos += ((speed * Time.smoothDeltaTime) * transform.up);
            }

            if(Input.GetKey(KeyCode.S))
            {
                pos -= ((speed * Time.smoothDeltaTime) * transform.up);
            }

            if(Input.GetKey(KeyCode.D))
            {
                transform.Rotate(transform.forward, -HeroRotateSpeed * Time.smoothDeltaTime);
            }

            if(Input.GetKey(KeyCode.A))
            {
                transform.Rotate(transform.forward, HeroRotateSpeed * Time.smoothDeltaTime);
            }

        }

        if(Input.GetKeyDown(KeyCode.Space) && Time.time > nextShot)
        {
    
            GameObject egg = Instantiate(Resources.Load("Prefabs/Egg") as GameObject); //Load egg
            egg.transform.localPosition = transform.localPosition;
            egg.transform.rotation = transform.rotation;
            nextShot = Time.time + shotCD;

        }

        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
       //Debug.Log("Hit");
        planesTagged++;
        EnemyCountText.text = "Planes Tagged: " + planesTagged;
        Destroy(collision.gameObject);
        heroGC.EnemyDestroyed();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        //Debug.Log("Stay");

    }

}
