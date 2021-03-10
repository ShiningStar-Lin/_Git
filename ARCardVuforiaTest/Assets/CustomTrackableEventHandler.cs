using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomTrackableEventHandler : DefaultTrackableEventHandler
{
    public GameObject planeObject;

    public GameObject[] panelObject;
    public float[] waitTime;

    protected bool isTracked;

    private bool isStart;
    private float time;
    private int size;
    
    protected override void Start()
    {
        base.Start();
        size = panelObject.Length;
    }
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        if (mTrackableBehaviour)
        {
            isTracked = true;
            if (planeObject != null)
            {
                planeObject.SetActive(true);
            }
        }
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        if (mTrackableBehaviour)
        {
            isTracked = false;
            if (planeObject != null)
            {
                planeObject.SetActive(false);
                time = 0;
            }
        }
    }

    protected virtual void Update()
    {
        if (isTracked)
        {
            time += Time.deltaTime;
            for (int i = 0; i < size; i++)
            {
                isStart = panelObject[i].GetComponent<ShowingObjectMoveRecord>().isStart;
                if (time > waitTime[i] && isStart == false)
                {
                    panelObject[i].GetComponent<ShowingObjectMoveRecord>().isStart = true;
                }
            }
        }
        else
        {
            for (int i = 0; i < size; i++)
            {
                isStart = panelObject[i].GetComponent<ShowingObjectMoveRecord>().isStart;
                if (isStart == true)
                {
                    panelObject[i].GetComponent<ShowingObjectMoveRecord>().isStart = false; 
                }
            }
        }
    }
}
