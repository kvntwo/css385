using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    private WaypointBehavior eWB = null;

    int current = 0;
    private float wpRadius = 1f;

    private const float offset = 270f;   
    private float rotationSpeed = 10f; 

    private bool noShuffle = true;
    private int randomWaypoint;
    // Start is called before the first frame update
    void Start()
    {
       //randomSpot = Random.RandomRange(0, waypoints.Length);
        eWB = FindObjectOfType<WaypointBehavior>();
        randomWaypoint = Random.Range(0, eWB.waypoints.Length);

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.J))
        {
            noShuffle = !noShuffle;
            Debug.Log("J Pressed!");

        }

        if(noShuffle)
        {

            //Debug.Log(eWB.waypoints.Length);
            //Debug.Log("Current Waypoint: " + eWB.waypoints[current]);
            //Debug.Log("Waypoint Position: " +  eWB.waypoints[current].transform.position);

            if(Vector2.Distance(transform.position, eWB.waypoints[current].transform.position) < wpRadius)
            {
                current++;
                if(current >= eWB.waypoints.Length)
                {
                    current = 0;
                }

            }

            transform.position = Vector2.MoveTowards(transform.position, eWB.waypoints[current].transform.position, Time.deltaTime * eWB.speed);
 
            //the code for making sure that the plane points in the right direction
            Vector3 direction = eWB.waypoints[current].transform.position - transform.position;
            direction.Normalize();
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle + offset, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);

        }
        else
        {

            if(Vector2.Distance(transform.position, eWB.waypoints[randomWaypoint].transform.position) < wpRadius)
            {
                randomWaypoint = Random.Range(0, eWB.waypoints.Length);

                if(randomWaypoint >= eWB.waypoints.Length)
                {
                    randomWaypoint = Random.Range(0, eWB.waypoints.Length);
                }

            }
            transform.position = Vector2.MoveTowards(transform.position, eWB.waypoints[randomWaypoint].transform.position, Time.deltaTime * eWB.speed);
            
            //the code for making sure that the plane points in the right direction
            Vector3 direction = eWB.waypoints[randomWaypoint].transform.position - transform.position;
            direction.Normalize();
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle + offset, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
            
        }


       
    }


}
