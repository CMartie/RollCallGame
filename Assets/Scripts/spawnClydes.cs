using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;



public class spawnClydes : MonoBehaviour
{
    public int clydeMin = 20;
    public int clydeMax = 40;
    public GameObject clyde;
    //public GameObject clydeSpawner;

    // public int numberOfClydes = 20;
    public int clydeSpawnAmount = 20;

    public List<clydeMoveForce> clydes = new List<clydeMoveForce>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnRandomClydes();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //  clydeSpawn();
      
    }
    /*public void clydeSpawn()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("I am spawning Clydes");
            Instantiate(clyde, clydeSpawner.transform.position, Quaternion.identity);
        }
       
    }*/
    public void spawnRandomClydes()
    {
        clydeSpawnAmount = Random.Range(clydeMin, clydeMax + 1);
        for (int count = 0; count < clydeSpawnAmount; count++)
        {
            

            Vector3 randomPosition = Vector3.zero;
            randomPosition.x = Random.Range(100f, 60f);
            randomPosition.y = Random.Range(0f, 2f);
            randomPosition.z = Random.Range(8f, -34f);

            GameObject newClyde = Instantiate(clyde, randomPosition, Quaternion.identity);
            // GameObject newClyde = Instantiate(clyde.transform.rotation(-90,0,0), randomPosition, Quaternion.identity;
            clydes.Add(newClyde.GetComponent<clydeMoveForce>());

            


        }

    }
}
