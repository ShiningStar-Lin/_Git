using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowingObjectMoveRecord : MonoBehaviour
{
    protected CustomTrackableEventHandler cus;

    [HideInInspector]
    public float objectY;
    public float objectYGoal;
    public float objectYIncrement;

    [HideInInspector]
    public bool isStart;

    protected GameObject imageTargetObject;
    protected Transform trans;
    // Start is called before the first frame update
    void Start()
    {
        //imageTargetObject = GameObject.Find("ImageTarget");
        //cus = imageTargetObject.GetComponent<CustomTrackableEventHandler>();
        trans = transform;

        objectY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(objectY) < Mathf.Abs(objectYGoal) && isStart == true)
        {
            objectY += objectYIncrement;
           
        }
        else if (isStart == false)
        {
            objectY = 0;
        }
        else { }

        trans.localPosition = new Vector3
             (
                trans.localPosition.x,
                objectY,
                trans.localPosition.z
              );
    }
}
