using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoPanel : MonoBehaviour
{
    public GameObject objParent;
    public GameObject infoPanel;
    public TMP_Text infoText;

    bool infoCard = false;

    public void InfoToggle()
    {
        if (infoCard == false)
        {
            infoCard = true;
        }

        else
        {
            infoCard = false;
        }
    }

    private void Update()
    {
        if (infoCard == true)
        {
            if (objParent.transform.GetChild(0).gameObject.activeInHierarchy)
            {
                infoText.text = "Obj1";
                infoPanel.gameObject.SetActive(true);
            }

            else if (objParent.transform.GetChild(1).gameObject.activeInHierarchy)
            {
                infoText.text = "Obj2";
                infoPanel.gameObject.SetActive(true);
            }

            else if (objParent.transform.GetChild(2).gameObject.activeInHierarchy)
            {
                infoText.text = "Obj3";
                infoPanel.gameObject.SetActive(true);
            }
        }

        if (infoCard == false)
        {
            infoPanel.gameObject.SetActive(false);
        }
    }
}
