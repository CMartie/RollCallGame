
using UnityEngine;
using System.Collections.Generic;
using System.Linq;


public class clydeKiller : MonoBehaviour
{
    public List<clydeMoveForce> clydes = new List<clydeMoveForce>();
   
    private clydeMoveForce whatHasExplode;

    float timeRange;

    public clydeMoveForce clydeController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // Invoke("ExplodeClydes");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExplodeClydes()
    {
        if(clydeController.explodeNumber == 5)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;

        }
       /* int clydesThatDie = Random.Range(0, clydes.Count);
        clydes[clydesThatDie].Explode();*/

      //  clydes.RemoveAt(clydesThatDie);
        timeRange = Random.Range(2f, 25f);

       // Invoke("ExplodeClydes");
    }

}
