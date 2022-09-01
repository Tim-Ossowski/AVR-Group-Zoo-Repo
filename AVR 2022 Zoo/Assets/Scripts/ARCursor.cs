using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARCursor : MonoBehaviour
{
    public GameObject cursorChildObject;
    public GameObject objectToPlace;
    public ARRaycastManager raycastManager;

    public bool useCursor = true;

    [SerializeField] AnimationsMenu animationsMenu;
    [SerializeField] ARPlaneManager aRPlainManager;

    void Start()
    {
        animationsMenu.gameObject.SetActive(false);
        objectToPlace.gameObject.SetActive(false);

        //set cursor active while variable is true
        cursorChildObject.SetActive(useCursor);
    }

    void Update()
    {
        if (useCursor)
        {
            UpdateCursor();
        }

        //instantiates object into the scene
        //checks to see if screen is touched using Unity input system, and whether it is a new touch or a held touch
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //checks for cursor
            if (useCursor)
            {
                //makes object at pos and rot of cursor
                //GameObject.Instantiate(objectToPlace, transform.position, transform.rotation);

                StartCoroutine(EnableMenu());
                StartCoroutine(ActivateObject());

                //useCursor = false;
            }

            else
            {
                //when there is no cursor, can place an object with raycasts with the touch position 
                List<ARRaycastHit> hits = new List<ARRaycastHit>();
                raycastManager.Raycast(Input.GetTouch(0).position, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

                //if touched, instantiate object at hit pos
                if (hits.Count > 0)
                {
                    StartCoroutine(ActivateObject());

                    //GameObject.Instantiate(objectToPlace, hits[0].pose.position, hits[0].pose.rotation);
                }
            }
        }
    }

    void UpdateCursor()
    {
        //screen pos to set cursor to
        Vector2 screenPos = Camera.main.ViewportToScreenPoint(new Vector2(.5f, .5f));

        //raycast to detect the planes that the cursor touches
        List<ARRaycastHit> hits = new List<ARRaycastHit>();

        //indicates to only detect planes
        raycastManager.Raycast(screenPos, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

        if (hits.Count > 0)
        {
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;
        }
    }

    IEnumerator EnableMenu()
    {
        animationsMenu.gameObject.SetActive(true);

        yield return null;
    }

    IEnumerator ActivateObject()
    {
        yield return new WaitForSeconds(.1f);

        objectToPlace.gameObject.SetActive(true);
        objectToPlace.gameObject.transform.position = transform.position;
        //DisablePlaneDetection();

        //yield return null;
    }

    /*public void DisablePlaneDetection()
    {
        aRPlainManager.gameObject.GetComponent<ARPlaneManager>().enabled = false;
    }*/
}
