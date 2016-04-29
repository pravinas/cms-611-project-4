﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{
    public Text timer;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    //private GUIStyle gs = new GUIStyle();

    void OnGUI()
    {
        float currentTime = Time.time - startTime;
        int minutes =  (int) currentTime / 60;
        int seconds = (int) currentTime % 60;

        Debug.Log("minutes:" + minutes);
        Debug.Log("seconds: " + seconds);

        string timeElapsed = string.Format("{0:00}:{1:00}", minutes, seconds);

        timer.text = timeElapsed;

        //gs.fontSize = 24;
        //gs.normal.textColor = Color.white;
        //GUILayout.Label("Time Elapsed: " + time.ToString(), gs);
    }
}