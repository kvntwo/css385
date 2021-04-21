using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggBehavior : MonoBehaviour
{
    public const float eggSpeed = 40f;

    private static int enemyEggHits = 0;
    private static int waypointEggHits = 0;

    private GameControllerBehavior eggGC = null;
    private WaypointBehavior eggWB = null;

    // Start is called before the first frame update
    void Start()
    {
        eggGC = FindObjectOfType<GameControllerBehavior>();

        eggWB = FindObjectOfType<WaypointBehavior>();

        //Egg life count set to eggLife
        //eggLifeCount =  eggLife;

    }

    // Update is called once per frame
    void Update()
    {
        
        //egg speed
        transform.position += transform.up * (eggSpeed * Time.smoothDeltaTime);

    }
    
    //destroys eggs if the exit the world boundaries
    void OnBecameInvisible() 
    {

        Destroy(transform.gameObject);   
        
    } 

    void OnCollisionEnter2D(Collision2D col)
    {

        //checks to see if tag of sprite is an enemy or not
        if(col.gameObject.tag == "Enemy")
        {   
            //eggHits has to equal 3 because syntax starts at 0
            if(enemyEggHits == 3)
            {
                //Debug.Log("Enemy Hit: " + eggHits);
                //reduce color
                Destroy(transform.gameObject);
                Destroy(col.gameObject);
                eggGC.EnemyDestroyed();
                enemyEggHits = 0;
            }
            else //enemy should be hit with egg until egghits reaches 3 as well as have its color reduced.
            {
                //Debug.Log("Egg Hits: " + eggHits);
                Destroy(transform.gameObject);
                col.gameObject.GetComponent<SpriteRenderer>().color =  col.gameObject.GetComponent<SpriteRenderer>().color * 0.8f;
                enemyEggHits++;

            }
        } 

        //checks tag of collided object to see if its a waypoint
        if(col.gameObject.tag == "Waypoint A" || col.gameObject.tag == "Waypoint B" || col.gameObject.tag == "Waypoint C" 
            || col.gameObject.tag == "Waypoint D" || col.gameObject.tag == "Waypoint E" || col.gameObject.tag == "Waypoint F")
        {
            if(waypointEggHits == 3)
            {
                Destroy(transform.gameObject);
                Destroy(col.gameObject);
                eggWB.checkWaypoint(col.gameObject);
                waypointEggHits = 0;

            }
            else
            {
                Destroy(transform.gameObject);
                col.gameObject.GetComponent<SpriteRenderer>().color =  col.gameObject.GetComponent<SpriteRenderer>().color * 0.75f;
                waypointEggHits++;

            }
           
        }

    }

}
