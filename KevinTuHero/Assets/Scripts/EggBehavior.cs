using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EggBehavior : MonoBehaviour
{
    public const float eggSpeed = 40f;

    // Start is called before the first frame update
    void Start()
    {
        //Egg life count set to eggLife
        //eggLifeCount =  eggLife;
    
    }

    // Update is called once per frame
    void Update()
    {
        
        //egg speed and the down tick of the egg's life
        transform.position += transform.up * (eggSpeed * Time.smoothDeltaTime);

    }
    
    //destroys eggs if the exit the world boundaries
    void OnBecameInvisible() {

        Destroy(transform.gameObject);

    }    
    
}
