using UnityEngine;
using TMPro;
public class showTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public GameObject timesUp;


    public float timeImageOnScreen = 2f;
   public float timeImageOff = 0f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timesUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingTime >= 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime <= 0)
        {
            remainingTime = 0;
           
            Destroy(timerText.gameObject);
            timesUpImage();
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

    public void timesUpImage()
    {
        timesUp.SetActive(true);

        timeImageOnScreen -= Time.deltaTime;
        if (timeImageOnScreen <= timeImageOff)
        {
            Debug.Log("The image is off now");
            timesUp.SetActive(false);
       }
    }
}
