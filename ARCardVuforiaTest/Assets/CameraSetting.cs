using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vuforia 
{
    public class CameraSetting : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
                var vuforia = VuforiaARController.Instance;
                vuforia.RegisterVuforiaStartedCallback(OnStarted);
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnStarted() 
        {
            CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        }
    }
}

