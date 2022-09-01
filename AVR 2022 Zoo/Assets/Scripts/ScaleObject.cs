using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    public GameObject scaleObject;

    private bool zoomIn;
    private bool zoomOut;

    public float scale = .1f;

    private void Update()
    {
        if (zoomIn)
        {
            scaleObject.gameObject.transform.localScale += new Vector3(scale, scale, scale);
        }

        if (zoomOut)
        {
            scaleObject.gameObject.transform.localScale -= new Vector3(scale, scale, scale);
        }
    }

    public void OnPressZoomIn()
    {
        zoomIn = true;
    }

    public void OnReleaseZoomIn()
    {
        zoomIn = false;
    }

    public void OnPressZoomOut()
    {
        zoomOut = true;
    }

    public void OnReleaseZoomOut()
    {
        zoomOut = false;
    }
}
