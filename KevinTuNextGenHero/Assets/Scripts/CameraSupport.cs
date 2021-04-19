using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSupport : MonoBehaviour
{

    private Camera mCamera;
    private Bounds mWorldBoundary;


    // Start is called before the first frame update
    void Start()
    {
        mCamera = gameObject.GetComponent<Camera>();
        mWorldBoundary = new Bounds();
        float maxY = mCamera.orthographicSize - 10;
        float maxX = (mCamera.orthographicSize - 10) * mCamera.aspect;
        float sizeX = 2 * maxX;
        float sizeY = 2 * maxY;
        Vector3 c = mCamera.transform.position;
        c.z = 0.0f;
        mWorldBoundary.center = c;
        mWorldBoundary.size = new Vector3(sizeX, sizeY, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Bounds GetWorldBoundary()
    {

        return mWorldBoundary;

    }

    public bool isInside(Bounds b1)
    {

        return isInsideBounds(b1, mWorldBoundary);
    }

    public bool isInsideBounds(Bounds b1, Bounds b2)
    {

        return (b1.min.x < b2.max.x) && (b1.max.x > b2.min.x) &&  
               (b1.min.y < b2.max.y) && (b1.max.y > b2.min.y);


    }

}
