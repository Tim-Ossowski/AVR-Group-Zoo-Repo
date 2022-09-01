using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using TMPro;

public class PlaneDetectToggle : MonoBehaviour
{
    [SerializeField] ARPlaneManager planeManager;
    [SerializeField] TMP_Text toggleButtonText;

    private void Awake()
    {
        toggleButtonText.text = "Plane Detect Disable";
    }

    public void TogglePlaneDetect()
    {
        //set plane manager enabled to current opposite
        planeManager.enabled = !planeManager.enabled;

        //dynamic message passed to toggle button for plane managers current state
        string toggleButtonMessage = "";

        if (planeManager.enabled)
        {
            toggleButtonMessage = "Plane Detect Disable";

            SetAllPlanesActive(true);
        }

        else
        {
            toggleButtonMessage = "Plane Detect Enable";

            SetAllPlanesActive(false);
        }

        toggleButtonText.text = toggleButtonMessage;
    }

    private void SetAllPlanesActive(bool value)
    {
        foreach (var plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(value);
        }
    }
}
