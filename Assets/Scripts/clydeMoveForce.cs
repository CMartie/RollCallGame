
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using JetBrains.Annotations;



public class clydeMoveForce : MonoBehaviour
{
   // public GameObject clyde;
    public float speed = 4f;
    public List<clydeMoveForce> clydes = new List<clydeMoveForce>();
    // public GameObject clydePrefab;
    float forceTimeGapMin = 1f;
    float forceTimegapmax = 3f;
    public int explodeNumber;
    float maxTimerforBomb = 25f;
    float minTimerforBomb = 2f;
    float randomBombTime;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomBombTime = Random.Range(minTimerforBomb, maxTimerforBomb);

        Invoke("randomClydeForce", forceTimeGapMin);

        explodeNumber = Random.Range(1, 11);

        Invoke("ExplodeClydes", randomBombTime);


       
        Debug.Log("this is my variable" + explodeNumber);

    // randomClydeForce();

    /*foreach (clydeMoveForce clyde in clydes)
    {
        clyde.randomClydeForce();
        Debug.Log("I am adding force to clydes");
    }*/

}

    // Update is called once per frame
    void Update()
    {
        //ExplodeClydes();

        // randomClydeForce();

        /*  foreach(clydeMoveForce clyde in clydes)
          {
              clyde.randomClydeForce();
              Debug.Log("I am adding force to clydes");
          }*/
        //Explode();

    }
    public void randomClydeForce()
    {

        Vector3 randomPosition = Vector3.zero;
        randomPosition.x = Random.Range(-6f, 6f);
        randomPosition.y = Random.Range(.5f, 6f);
        randomPosition.z = Random.Range(-6f, 6f);

        //this.gameObject.transform.position += randomPosition * speed *Time.deltaTime;
        // clydePrefab.gameObject.GetComponent<Rigidbody>().AddForce(randomPosition * speed * Time.deltaTime);

        float forceStrength = Random.Range(10f, 200f);

        this.gameObject.GetComponent<Rigidbody>().AddForce(randomPosition * forceStrength);

        float randomTimeGap = Random.Range(forceTimeGapMin, forceTimegapmax);

        Invoke("randomClydeForce", randomTimeGap);

    }
    
    public void ExplodeClydes()
    {
        Debug.Log("explode function ran");

        if (explodeNumber == 5)
        {
      
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("im dead");
            
            
        }
        //Invoke("ExplodeClydes", randomBombTime);

        /* int clydesThatDie = Random.Range(0, clydes.Count);
         clydes[clydesThatDie].Explode();*/

        //  clydes.RemoveAt(clydesThatDie);
        //timeRange = Random.Range(2f, 25f);

        // Invoke("ExplodeClydes");
    }


}
