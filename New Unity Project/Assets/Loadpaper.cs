using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadpaper : MonoBehaviour
{
    public printing setLoaded;

    public void loadandDisable(){
        transform.parent.GetChild(1).gameObject.SetActive(true);
        transform.parent.GetChild(2).gameObject.SetActive(true);

        setLoaded.loadedPaper = true;
        gameObject.layer = 12;

    }
}
