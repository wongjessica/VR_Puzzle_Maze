using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlueBallMove : MonoBehaviour
{
    public float gazeTime = 2f;

    public float timer;

    public bool gazedAt;

    static bool objectChosen;

    static GameObject chosenObjectName;

    void Update ()
    {
        if (gazedAt)
        {
            Debug.Log("we got a gaze.");
            timer += Time.deltaTime;
            if (timer >= gazeTime)
            {
                if (objectChosen == false)
                {
                    Debug.Log("Object Chosen");
                    this.transform.position = new Vector3(this.transform.position.x, 2.5f, this.transform.position.z);
                    timer = 0f;
                    objectChosen = true;
                    chosenObjectName = this.gameObject;
                }
                else
                {
                    if (chosenObjectName == this.gameObject)
                    {
                        this.transform.position = new Vector3(this.transform.position.x, 1f, this.transform.position.z);
                        timer = 0f;
                        objectChosen = false;
                        chosenObjectName = null;
                    }
                }
            }
        }
    }

    public void PointerEnter()
    {
        gazedAt = true;
    }

    public void PointerExit()
    {
        gazedAt = false;
    }

    public void PointerClick()
    {
        if ((objectChosen) && this.transform.position.z != 2)
        {
            this.transform.position = new Vector3(this.transform.position.x, 1f, this.transform.position.z - 2f);
            objectChosen = false;
        }
        else if ((objectChosen) && this.transform.position.z == 2)
        {
            this.transform.position = new Vector3(this.transform.position.x, 1f, 10f);
            objectChosen = false;
        }
    }
}

