using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggBehavior : MonoBehaviour
{
    public const float eggSpeed = 40f;
    public static int eggHits = 0;
    private GameControllerBehavior eggGC = null;

    // Start is called before the first frame update
    void Start()
    {
        eggGC = FindObjectOfType<GameControllerBehavior>();

        //Egg life count set to eggLife
        //eggLifeCount =  eggLife;

    }

    // Update is called once per frame
    void Update()
    {
        
        //egg speed
        transform.position += transform.up * (eggSpeed * Time.smoothDeltaTime);

    }
    
    //destroys eggs if the exit the world boundaries
    void OnBecameInvisible() 
    {

        Destroy(transform.gameObject);   
        
    } 

    void OnCollisionEnter2D(Collision2D col)
    {

        //checks to see if tag of sprite is an egg or not
        if(col.gameObject.tag == "Enemy")
        {   
            //eggHits has to equal 3 because syntax starts at 0
            if(eggHits == 3)
            {
                //Debug.Log("Enemy Hit: " + eggHits);
                //reduce color
                Destroy(transform.gameObject);
                Destroy(col.gameObject);
                eggGC.EnemyDestroyed();
                eggHits = 0;
            }
            else //enemy should be hit with egg until egghits reaches 3 as well as have its color reduced.
            {
                //Debug.Log("Egg Hits: " + eggHits);
                Destroy(transform.gameObject);
                col.gameObject.GetComponent<SpriteRenderer>().color =  col.gameObject.GetComponent<SpriteRenderer>().color * 0.8f;
                eggHits++;

            }
        }  

    }

}
