using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapPhone : MonoBehaviour
{
    public Camera arCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = arCamera.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "Plane")
                {
                    Application.OpenURL("https://www.zhihu.com/people/albertlee-15");
                }
            }
        }
    }
}
