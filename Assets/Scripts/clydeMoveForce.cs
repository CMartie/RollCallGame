
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;



public class clydeMoveForce : MonoBehaviour
{
   // public GameObject clyde;
    public float speed = 4f;
    public List<clydeMoveForce> clydes = new List<clydeMoveForce>();
    // public GameObject clydePrefab;
    float forceTimeGapMin = 1f;
    float forceTimegapmax = 3f;


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("randomClydeForce", forceTimeGapMin);

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

        Invoke("randomClydeForce", forceTimeGapMin);

    }
    public void Explode()
    {
        Destroy(this.gameObject);
    }


}
