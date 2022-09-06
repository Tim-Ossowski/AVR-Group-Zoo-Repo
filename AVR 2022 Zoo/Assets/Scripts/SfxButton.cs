using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxButton : MonoBehaviour
{
    public GameObject objParent;
    public AudioSource itemOne;
    public AudioSource itemTwo;
    public AudioSource itemThree;

    bool sFXButton = false;

    public void Start()
    {
        //itemOne = objParent.transform.GetChild(0).gameObject.AudioSource;
        //itemTwo = objParent.transform.GetChild(0).gameObject.AudioSource;
        //itemThree = objParent.transform.GetChild(0).gameObject.AudioSource;
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
                //infoText.text = "Obj1";
                //SfxPlay.gameObject.SetActive(true);
                //objParent.transform.GetChild(0).gameObject.transform.AudioSource;
            }

            else if (objParent.transform.GetChild(1).gameObject.activeInHierarchy)
            {
                //infoText.text = "Obj2";
                //SfxPlay.gameObject.SetActive(true);
            }

            else if (objParent.transform.GetChild(2).gameObject.activeInHierarchy)
            {
                //infoText.text = "Obj3";
                //SfxPlay.gameObject.SetActive(true);
            }
        }

        if (sFXButton == false)
        {
            //infoPanel.gameObject.SetActive(false);
        }
    }
}
