using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaypointBehavior : MonoBehaviour
{
    private int maxWay = 1;

    private int wayA = 0;
    private int wayB = 0;
    private int wayC = 0;
    private int wayD = 0;
    private int wayE = 0;
    private int wayF = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(wayA < maxWay)
        {
            GameObject WaypointA = Instantiate(Resources.Load("Prefabs/Waypoint_A") as GameObject);
            Vector3 aPos;

            //Spawn near top left of map;
            aPos.x = Random.Range(-80, -65);
            aPos.y = Random.Range(50, 75);
            aPos.z = 0;
            WaypointA.transform.localPosition = aPos;
            wayA++;

        }

        if(wayB < maxWay)
        {
            GameObject WaypointB = Instantiate(Resources.Load("Prefabs/Waypoint_B") as GameObject);
            Vector3 bPos;

            //Spawn near top left of map;
            bPos.x = Random.Range(70, 90);
            bPos.y = Random.Range(-80, -60);
            bPos.z = 0;
            WaypointB.transform.localPosition = bPos;
            wayB++;

        }

        if(wayC < maxWay)
        {
            GameObject WaypointC = Instantiate(Resources.Load("Prefabs/Waypoint_C") as GameObject);
            Vector3 cPos;

            //Spawn near top left of map;
            cPos.x = Random.Range(20, 50);
            cPos.y = Random.Range(-15, 5);
            cPos.z = 0;
            WaypointC.transform.localPosition = cPos;
            wayC++;

        }

        if(wayD < maxWay)
        {
            GameObject WaypointD = Instantiate(Resources.Load("Prefabs/Waypoint_D") as GameObject);
            Vector3 dPos;

            //Spawn near top left of map;
            dPos.x = Random.Range(-80, -65);
            dPos.y = Random.Range(-80, -60);
            dPos.z = 0;
            WaypointD.transform.localPosition = dPos;
            wayD++;

        }

        if(wayE < maxWay)
        {
            GameObject WaypointE = Instantiate(Resources.Load("Prefabs/Waypoint_E") as GameObject);
            Vector3 ePos;

            //Spawn near top left of map;
            ePos.x = Random.Range(70, 90);
            ePos.y = Random.Range(50, 75);
            ePos.z = 0;
            WaypointE.transform.localPosition = ePos;
            wayE++;

        }

        if(wayF < maxWay)
        {
            GameObject WaypointF = Instantiate(Resources.Load("Prefabs/Waypoint_F") as GameObject);
            Vector3 fPos;

            //Spawn near top left of map;
            fPos.x = Random.Range(-50, -20);
            fPos.y = Random.Range(-15, 5);
            fPos.z = 0;
            WaypointF.transform.localPosition = fPos;
            wayF++;

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
