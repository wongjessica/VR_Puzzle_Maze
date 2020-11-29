using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class closeBook : MonoBehaviour
{
    public Button exitbutton;
    public GameObject closebook;
    public bookcoveropen setit;


    // Start is called before the first frame update
    void Start()
    {
        exitbutton.onClick.AddListener(() => closebook_Click());
    }

    private void closebook_Click()
    {
        closebook.SetActive(true);
        setit.closeBtn_Click();
        gameObject.SetActive(false);
    }

}
