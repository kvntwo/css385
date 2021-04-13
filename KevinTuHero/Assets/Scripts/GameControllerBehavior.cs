using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerBehavior : MonoBehaviour
{
    public Text enemyAliveText = null;
    private int maxEnemies = 10;
    private int numOfEnemies = 0;
    private int aliveEnemies = 0;

    private int eggHits = 0;

    // Start is called before the first frame update
    void Start()
    {
        enemyAliveText.text = "Enemy Alive: ";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q)){
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
          Application.Quit();  
#endif       
        }

    
        if(numOfEnemies < maxEnemies)
        {

            CameraSupport s = Camera.main.GetComponent<CameraSupport>();

            GameObject enemy = Instantiate(Resources.Load("Prefabs/Enemy") as GameObject);
            aliveEnemies++;
            enemyAliveText.text = "Enemy Alive: "  + aliveEnemies;
        
            Vector3 pos;
            pos.x = s.GetWorldBoundary().min.x + Random.value * s.GetWorldBoundary().size.x;
            pos.y = s.GetWorldBoundary().min.y + Random.value * s.GetWorldBoundary().size.y;
            pos.z = 0;
            enemy.transform.localPosition = pos;
            numOfEnemies++;

        }        
        
    }

    public void EnemyDestroyed()
    {

        numOfEnemies--;
        aliveEnemies--;
        enemyAliveText.text = "Enemy Alive: "  + aliveEnemies;

    }

}
