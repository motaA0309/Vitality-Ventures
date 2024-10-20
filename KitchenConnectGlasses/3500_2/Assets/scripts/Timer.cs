using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float duration = 300;
    private float remaining;
    public TMP_Text timerText;
    private bool running = false;
    public GameObject actionButton;

    // Start is called before the first frame update
    void Start()
    {
        remaining = duration;
    }

    // Update is called once per frame
    void Update()
    {
        if (running && remaining > 0)
        {
            remaining -= Time.deltaTime;
            if(remaining >= 0)
                UpdateTimeText(remaining);
        }
        else
        {
            if (remaining <= 0)
            {
                remaining = 0;
                Stop();
                UpdateTimeText(remaining);
            }
        }
       
    }

    public void Run()
    {
        remaining = duration;
        running = true;
        actionButton.SetActive(false);
    }

    public void Stop()
    {
        running = false;
        timerText.text = "";
        actionButton.SetActive(true);
    }
    void UpdateTimeText(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
