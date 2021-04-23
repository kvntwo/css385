using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaypointBehavior : MonoBehaviour
{
    private int maxWay = 1;
    private int wayA, wayB, wayC, wayD, wayE, wayF = 0;

    private GameObject WaypointA, WaypointB, WaypointC, WaypointD, WaypointE, WaypointF;
    
    private Vector3 aPos, bPos, cPos, dPos, ePos, fPos;
    private float startAX, startAY, startBX, startBY, startCX, startCY,
                startDX, startDY, startEX, startEY, startFX, startFY;
    public GameObject[] waypoints;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //I wanted to make it so that all waypoints begin in a random location
        startSpawn();

    }

    // Update is called once per frame
    void Update()
    {
        if(wayA < maxWay)
        {
            WaypointA = Instantiate(Resources.Load("Prefabs/Waypoint_A") as GameObject);
            WaypointA.transform.position = aPos; 
            waypoints[0] = WaypointA;
            wayA++;

        }

        if(wayB < maxWay)
        {
            WaypointB = Instantiate(Resources.Load("Prefabs/Waypoint_B") as GameObject);
            WaypointB.transform.localPosition = bPos;
            waypoints[1] = WaypointB;
            wayB++;

        }

        if(wayC < maxWay)
        {
            WaypointC = Instantiate(Resources.Load("Prefabs/Waypoint_C") as GameObject);
            WaypointC.transform.localPosition = cPos;
            waypoints[2] = WaypointC;
            wayC++;

        }

        if(wayD < maxWay)
        {
            WaypointD = Instantiate(Resources.Load("Prefabs/Waypoint_D") as GameObject);
            WaypointD.transform.localPosition = dPos;
            waypoints[3] = WaypointD;
            wayD++;

        }

        if(wayE < maxWay)
        {
            WaypointE = Instantiate(Resources.Load("Prefabs/Waypoint_E") as GameObject);
            WaypointE.transform.localPosition = ePos;
            waypoints[4] = WaypointE;
            wayE++;

        }

        if(wayF < maxWay)
        {
            WaypointF = Instantiate(Resources.Load("Prefabs/Waypoint_F") as GameObject);
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

    }

    public void randomRespawn()
    {
      
        aPos.x = Random.Range(startAX - 15f, startAX + 15f);
        aPos.y = Random.Range(startAY - 15f, startAY + 15f);

        bPos.x = Random.Range(startBX - 15f, startBX + 15f);
        bPos.y = Random.Range(startBY - 15f, startBY + 15f);

        cPos.x = Random.Range(startCX - 15f, startCX + 15f);
        cPos.y = Random.Range(startCY - 15f, startCY + 15f);

        dPos.x = Random.Range(startDX - 15f, startDX + 15f);
        dPos.y = Random.Range(startDY - 15f, startDY + 15f);

        ePos.x = Random.Range(startEX - 15f, startEX + 15f);
        ePos.y = Random.Range(startEY - 15f, startEY + 15f);

        fPos.x = Random.Range(startFX - 15f, startFX + 15f);
        fPos.y = Random.Range(startFY - 15f, startFY + 15f);

    }

    public void startSpawn()
    {
        //Waypoint A starting position
        aPos.x = Random.Range(-180, 180);
        aPos.y = Random.Range(-80, 80);
        aPos.z = 0;
        //Starting position saved
        startAX = aPos.x;
        startAY = aPos.y;

        //Waypoint B starting position
        bPos.x = Random.Range(-180, 180);
        bPos.y = Random.Range(-80, 80);
        bPos.z = 0;
        //Starting position saved
        startBX = bPos.x;
        startBY = bPos.y;

        //Waypoint C starting position
        cPos.x = Random.Range(-180, 180);
        cPos.y = Random.Range(-80, 80);
        cPos.z = 0;
        //Starting position saved
        startCX = cPos.x;
        startCY = cPos.y;

        //Waypoint D starting position
        dPos.x = Random.Range(-180, 180);
        dPos.y = Random.Range(-80, 80);
        dPos.z = 0;
        //Starting position saved
        startDX = dPos.x;
        startDY = dPos.y;

        //Waypoint E starting position
        ePos.x = Random.Range(-180, 180);
        ePos.y = Random.Range(-80, 80);
        ePos.z = 0;
        //Starting position saved
        startEX = ePos.x;
        startEY = ePos.y;

        //Waypoint F starting position
        fPos.x = Random.Range(-180, 180);
        fPos.y = Random.Range(-80, 80);
        fPos.z = 0;
        //Starting position saved
        startFX = fPos.x;
        startFY = fPos.y;

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
