using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class mysteriousbook : MonoBehaviour{
    public GameObject bookTrigger;

    public void toggleBook(){
        bookTrigger.SetActive(true);
    }
}
