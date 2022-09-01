using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsMenu : MonoBehaviour
{
    //[SerializeField] List<GameObject> objectPrefabs = new List<GameObject>();
    [SerializeField] ARCursor arCursor;

    //[SerializeField] GameObject buttonOne;
    //[SerializeField] GameObject buttonTwo;
    //[SerializeField] GameObject buttonThree;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetAnimationOne()
    {
        arCursor.objectToPlace.transform.GetChild(0).gameObject.SetActive(true);
        arCursor.objectToPlace.transform.GetChild(1).gameObject.SetActive(false);
        arCursor.objectToPlace.transform.GetChild(2).gameObject.SetActive(false);

        StartCoroutine(CursorCheck());
    }

    public void SetAnimationTwo()
    {
        arCursor.objectToPlace.transform.GetChild(0).gameObject.SetActive(false);
        arCursor.objectToPlace.transform.GetChild(1).gameObject.SetActive(true);
        arCursor.objectToPlace.transform.GetChild(2).gameObject.SetActive(false);

        StartCoroutine(CursorCheck());
    }

    public void SetAnimationThree()
    {
        arCursor.objectToPlace.transform.GetChild(0).gameObject.SetActive(false);
        arCursor.objectToPlace.transform.GetChild(1).gameObject.SetActive(false);
        arCursor.objectToPlace.transform.GetChild(2).gameObject.SetActive(true);

        StartCoroutine(CursorCheck());
    }

    IEnumerator CursorCheck()
    {
        if (!arCursor.useCursor)
        {
            arCursor.useCursor = true;
        }

        else
        {
            arCursor.useCursor = false;
        }

        yield return null;
    }
}
