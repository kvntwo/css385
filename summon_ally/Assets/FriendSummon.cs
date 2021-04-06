using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendSummon : MonoBehaviour
{

    public GameObject Friend;
    public GameObject Friend2;
    float FriendTimer;

    // Start is called before the first frame update
    void Start()
    {
        FriendTimer = Time.time -10f;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Q))
       {
            Vector3 Friend1Loc = new Vector3(transform.localPosition.x - 1.5f, transform.localPosition.y - 1f, 0f);
            Vector3 Friend2Loc = new Vector3(transform.localPosition.x + 1.5f, transform.localPosition.y + 1f, 0f);
            Friend.transform.localPosition = Friend1Loc;
            Friend2.transform.localPosition = Friend2Loc;
            FriendTimer = Time.time;
       } 

       if (Time.time - FriendTimer < 10)
        {
            Friend.transform.parent = transform;
            Friend2.transform.parent = transform;
        }
        else
        {
            Friend.transform.parent = null;
            Friend2.transform.parent = null;
        }
    }
}
