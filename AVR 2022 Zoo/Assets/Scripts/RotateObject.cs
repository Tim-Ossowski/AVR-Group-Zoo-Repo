using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public GameObject objectRotate;

    public float rotateSpeed = 50f;

    bool rotateStatus = false;

    public void RotObject()
    {
        if (rotateStatus == false)
        {
            rotateStatus = true;
        }

        else
        {
            rotateStatus = false;
        }
    }

    private void Update()
    {
        if (rotateStatus == true)
        {
            if (objectRotate.transform.GetChild(0).gameObject.activeInHierarchy)
            {
                objectRotate.transform.GetChild(0).gameObject.transform.Rotate(Vector2.up, rotateSpeed * Time.deltaTime);
            }

            else if (objectRotate.transform.GetChild(1).gameObject.activeInHierarchy)
            {
                objectRotate.transform.GetChild(1).gameObject.transform.Rotate(Vector2.up, rotateSpeed * Time.deltaTime);
            }

            else if (objectRotate.transform.GetChild(2).gameObject.activeInHierarchy)
            {
                objectRotate.transform.GetChild(2).gameObject.transform.Rotate(Vector2.up, rotateSpeed * Time.deltaTime);
            }
        }
    }
}
