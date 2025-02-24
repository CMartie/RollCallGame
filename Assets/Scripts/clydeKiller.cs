using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;


public class clydeKiller : MonoBehaviour
{
    public List<clydeMoveForce> clydes = new List<clydeMoveForce>();
   
    public clydeMoveForce whatHasExplode;

    float timeRange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExplodeClydes()
    {
        int clydesThatDie = Random.Range(0, clydes.Count);
        clydes[clydesThatDie].Explode();
        clydes.RemoveAt(clydesThatDie);
        timeRange = Random.Range(2f, 25f);

        //Invoke("ExplodeClydes"
    }

}
