using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class clydeKiller : MonoBehaviour
{
    public List<clydeMoveForce> clydes = new List<clydeMoveForce>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int clydesThatDie = Random.Range(0, clydes.Count);
        //clydes[clydesThatDie].Explode();
        clydes.RemoveAt(clydesThatDie);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Explode()
    {
        Destroy(this.gameObject);
    }

}
