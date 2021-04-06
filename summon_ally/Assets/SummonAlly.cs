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