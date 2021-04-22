using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaypointBehavior : MonoBehaviour
{
    private int maxWay = 1;
    private int wayA, wayB, wayC, wayD, wayE, wayF = 0;

    private GameObject WaypointA, WaypointB, WaypointC, WaypointD, WaypointE, WaypointF;

    public GameObject[] waypoints;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(wayA < maxWay)
        {
            WaypointA = Instantiate(Resources.Load("Prefabs/Waypoint_A") as GameObject);

            Vector3 aPos;
            aPos.x = Random.Range(-80, -65);
            aPos.y = Random.Range(50, 75);
            aPos.z = 0;
            WaypointA.transform.position = aPos; 
            waypoints[0] = WaypointA;
            wayA++;

        }

        if(wayB < maxWay)
        {
            WaypointB = Instantiate(Resources.Load("Prefabs/Waypoint_B") as GameObject);

            Vector3 bPos;
            bPos.x = Random.Range(70, 90);
            bPos.y = Random.Range(-80, -60);
            bPos.z = 0;
            WaypointB.transform.localPosition = bPos;
            waypoints[1] = WaypointB;
            wayB++;

        }

        if(wayC < maxWay)
        {
            WaypointC = Instantiate(Resources.Load("Prefabs/Waypoint_C") as GameObject);

            Vector3 cPos;
            cPos.x = Random.Range(20, 50);
            cPos.y = Random.Range(-15, 5);
            cPos.z = 0;
            WaypointC.transform.localPosition = cPos;
            waypoints[2] = WaypointC;
            wayC++;

        }

        if(wayD < maxWay)
        {
            WaypointD = Instantiate(Resources.Load("Prefabs/Waypoint_D") as GameObject);

            Vector3 dPos;
            dPos.x = Random.Range(-80, -65);
            dPos.y = Random.Range(-80, -60);
            dPos.z = 0;
            WaypointD.transform.localPosition = dPos;
            waypoints[3] = WaypointD;
            wayD++;

        }

        if(wayE < maxWay)
        {
            WaypointE = Instantiate(Resources.Load("Prefabs/Waypoint_E") as GameObject);

            Vector3 ePos;
            ePos.x = Random.Range(70, 90);
            ePos.y = Random.Range(50, 75);
            ePos.z = 0;
            WaypointE.transform.localPosition = ePos;
            waypoints[4] = WaypointE;
            wayE++;

        }

        if(wayF < maxWay)
        {
            WaypointF = Instantiate(Resources.Load("Prefabs/Waypoint_F") as GameObject);
            
            Vector3 fPos;
            fPos.x = Random.Range(-50, -20);
            fPos.y = Random.Range(-15, 5);
            fPos.z = 0;
            WaypointF.transform.localPosition = fPos;
            waypoints[5] = WaypointF;
            wayF++;

        }

        if(Input.GetKeyDown(KeyCode.H)) 
        {

            //toggles visibilty for all waypoints using for loop
            for(int i = 0;  i < waypoints.Length; i++)
            {

                waypoints[i].GetComponent<Renderer>().enabled = !waypoints[i].GetComponent<Renderer>().enabled;

            }

        }

        if(Input.GetKeyDown(KeyCode.J))
        {



        }

    }

    public void shuffle()
    {
        
        for(int i = 0; i < (waypoints.Length - 1); i++)
        {
     

        }

    }


    public void checkWaypoint(GameObject gc) 
    {
        if(gc.tag == "Waypoint A")
        {

            wayA--;

        }
        else if(gc.tag == "Waypoint B")
        {

            wayB--;

        }
        else if(gc.tag == "Waypoint C")
        {

            wayC--;

        }
        else if(gc.tag == "Waypoint D")
        {

            wayD--;

        }
        else if(gc.tag == "Waypoint E")
        {

            wayE--;

        }
        else if(gc.tag == "Waypoint F")
        {

            wayF--;

        }
        
    }

}
