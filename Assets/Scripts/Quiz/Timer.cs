using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text timer;
    [SerializeField] private float remainingTime;

    [SerializeField] private GameObject gameOver;

    [SerializeField] private GameObject trigger;
    // Update is called once per frame
    void Update()
    {
        TimerCount();
    }

    private void TimerCount()
    {
        if (remainingTime > 0) 
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime <= 0)
        {
            remainingTime = 0;
            gameOver.SetActive(true);
            trigger.SetActive(false);
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
