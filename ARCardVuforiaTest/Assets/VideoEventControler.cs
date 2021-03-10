using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoEventControler : MonoBehaviour
{
    protected VideoPlayer vp;
    public RenderTexture renderTexture;
    public Texture startTexture;

    private void Start()
    {
        vp = GetComponent<VideoPlayer>();
    }

    private void OnEnable()
    {
        vp = GetComponent<VideoPlayer>();
        if (vp != null)
        {
            vp.Play();
        }
    }

    private void OnDisable()
    {
        if (vp != null)
        {
            vp.Stop();
            Graphics.Blit(startTexture, renderTexture);
        }
    }
}
