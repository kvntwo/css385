using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    private WaypointBehavior eWB = null;

    int current = 0;
    private float wpRadius = 0.2f;

    private int randomSpot;

    // Start is called before the first frame update
    void Start()
    {
       //randomSpot = Random.RandomRange(0, waypoints.Length);
        eWB = FindObjectOfType<WaypointBehavior>();

    }

    // Update is called once per frame
    void Update()
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
        
    }
}
