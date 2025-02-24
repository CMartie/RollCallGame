using NUnit.Framework;
using UnityEngine;

public class clydeMoveForce : MonoBehaviour
{
   // public GameObject clyde;
    public float speed = 4f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void randomClydeForce()
    {
        Vector3 randomPosition = Vector3.zero;
        randomPosition.x = Random.Range(100f, 60f);
        randomPosition.y = Random.Range(0f, 2f);
        randomPosition.z = Random.Range(8f, -34f);

        this.gameObject.transform.position += randomPosition * speed *Time.deltaTime;

    }
}
