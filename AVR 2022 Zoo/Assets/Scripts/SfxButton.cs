using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxButton : MonoBehaviour
{
    public GameObject objParent;
    private AudioSource itemOne;
    private AudioSource itemTwo;
    private AudioSource itemThree;

    bool sFXButton = false;

    public void Start()
    {
        itemOne = objParent.transform.GetChild(0).GetComponent<AudioSource>();
        itemTwo = objParent.transform.GetChild(0).GetComponent<AudioSource>();
        itemThree = objParent.transform.GetChild(0).GetComponent<AudioSource>();
    }

    public void SFXToggle()
    {
        if (sFXButton == false)
        {
            sFXButton = true;
        }

        else
        {
            sFXButton = false;
        }
    }

    private void Update()
    {
        if (sFXButton == true)
        {
            if (objParent.transform.GetChild(0).gameObject.activeInHierarchy)
            {
                itemOne.Play();
            }

            else if (objParent.transform.GetChild(1).gameObject.activeInHierarchy)
            {
                itemTwo.Play();
            }

            else if (objParent.transform.GetChild(2).gameObject.activeInHierarchy)
            {
                itemThree.Play();
            }
        }

        if (sFXButton == false)
        {
            if (objParent.transform.GetChild(0).gameObject.activeInHierarchy)
            {
                itemOne.Stop();
            }

            else if (objParent.transform.GetChild(1).gameObject.activeInHierarchy)
            {
                itemTwo.Stop();
            }

            else if (objParent.transform.GetChild(2).gameObject.activeInHierarchy)
            {
                itemThree.Stop();
            }
        }
    }
}
