using UnityEngine;

public class countClyde : MonoBehaviour
{
    public float timerCountingDown = 30f;
    public float timerEnd = 0f;
    public bool hasFinishedTimer = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerCountingDown -= Time.deltaTime;
         if(timerCountingDown <= timerEnd)
        {
            Debug.Log("Time's Up!");

            timerCountingDown = 0f;
            hasFinishedTimer = true;

        }
    }
}
