# Summon Ally

## Description
This mechanic will demonstrate how to allow the player to summon an ally with a simple key press. When the key is pressed, the ally will follow the player for 5 seconds.

## Implementation
Make sure there is a player object and an ally object in the scene. Attach the following SummonAlly script to the player.


    using UnityEngine;

    public class SummonAlly : MonoBehaviour
    {
        public GameObject ally;
        float timerStart;

        void Start()
        {
            timerStart = Time.time -5f;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Vector3 allyLoc = new Vector3(transform.localPosition.x - 0.65f, transform.localPosition.y - 0.65f, 0f);
                ally.transform.localPosition = allyLoc;
                timerStart = Time.time;
            }

            if (Time.time - timerStart < 5)
            {
                ally.transform.parent = transform;
            }
            else
            {
                ally.transform.parent = null;
            }
        }
    }