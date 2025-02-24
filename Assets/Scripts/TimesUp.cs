using System.Threading;
using UnityEngine;

public class TimesUp : MonoBehaviour
{
    public GameObject timesUp;
    public float timeImageOnScreen = 1f;
    public float timeImageOff = 30f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void timesUpImage()
    {
        timesUp.SetActive(false);

        timeImageOff += Time.deltaTime;
        if (timeImageOff >= timeImageOnScreen)
        {
            Debug.Log("The image is on now");
            timesUp.SetActive(true);
        }
    }
}
