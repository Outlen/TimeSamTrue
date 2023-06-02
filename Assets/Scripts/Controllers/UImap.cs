using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImap : MonoBehaviour
{
    public bool isImgOn;
    public Image imgMap;
    // Start is called before the first frame update
    void Start()
    {
        imgMap.enabled = false;
        isImgOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isImgOn) 
            {
                imgMap.enabled = false;
                isImgOn = false;
            }

            else
            {
                imgMap.enabled = true;
                isImgOn = true;
            }
        }
    }
}
