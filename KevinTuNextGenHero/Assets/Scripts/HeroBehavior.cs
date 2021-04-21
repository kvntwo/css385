using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroBehavior : MonoBehaviour
{
    private GameObject[] getCount;
    public Text EnemyKilledText = null;
    public Text EggText = null;

    //Egg cooldown should make it so that it shoots ever 0.2 secounds
    private float eggCD = 0.2f;
    private float eggFireTime = 0f;

    //intial speed of 20/sec and turn rate of 45/sec
    public float speed = 20f;
    public float HeroRotateSpeed = 90f / 2;

    public bool FollowMouse = true;

    private int planesTagged = 0;
    private GameControllerBehavior heroGC = null;

    // Start is called before the first frame update
    void Start()
    {
       
        EggText.text = "Eggs on Screen: 0";
        EnemyKilledText.text = "Planes Touched: 0";
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
            //Debug.Log("Position is " + pos);
            pos.z = 0f;
            //Debug.Log("Screen Point:" + Input.mousePosition);

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

        transform.position = pos;

        //Shoot eggs with spacebar
        if(Input.GetKeyDown(KeyCode.Space) && Time.time > eggFireTime)
        {
            
            GameObject egg = Instantiate(Resources.Load("Prefabs/Egg") as GameObject); //Load egg
            egg.transform.localPosition = transform.localPosition;
            egg.transform.rotation = transform.rotation;
            eggFireTime = Time.time + eggCD;

        }

        //These two lines will count the number of eggs on the screen
        getCount = GameObject.FindGameObjectsWithTag("Bullet");
        EggText.text = "Eggs on Screen: " + getCount.Length;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //checks to see if tag of sprite is an egg or not
        if(collision.gameObject.tag == "Enemy")
        {
            //Debug.Log("Hit");
            planesTagged++;
            EnemyKilledText.text = "Planes Touched: " + planesTagged;
            Destroy(collision.gameObject);
            heroGC.EnemyDestroyed();
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        //Debug.Log("Stay");
        
        
    }


}
