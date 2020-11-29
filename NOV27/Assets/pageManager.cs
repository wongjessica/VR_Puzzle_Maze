using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pageManager: MonoBehaviour{
    public static pageManager pageMan;

    public flipPage[] flipPages;

    public Button prevButton;
    public Button nextButton;

    public int currpage = 0;

    public enum ButtonType{
        prevButton, nextButton
    }

    void Awake(){
        //set all pages inactive besides first
        foreach (flipPage f in flipPages){
            f.gameObject.SetActive(false);
        }
        flipPages[0].gameObject.SetActive(true);
        prevButton.gameObject.SetActive(false); 
    }
    //0 1 2
    void Start(){
        prevButton.onClick.AddListener(() => openBtn_Click(ButtonType.prevButton));
        nextButton.onClick.AddListener(() => openBtn_Click(ButtonType.nextButton));
    }
    public void updatePage(int leftorRight){
        if(leftorRight == 1){
            currpage++;
            if (currpage > 0){
                prevButton.gameObject.SetActive(true); 
                //Debug.Log(currpage);
                flipPages[currpage].gameObject.SetActive(true);
            }
            if(currpage == flipPages.Length - 1){
                nextButton.gameObject.SetActive(false); 
                //flipPages[currpage].gameObject.SetActive(true);
            }
            if(currpage - 2 >= 0){
                flipPages[currpage - 2].gameObject.SetActive(false);
            }
        }
        else if(leftorRight == 0){
            if (currpage < flipPages.Length - 1){
                nextButton.gameObject.SetActive(true); 
                flipPages[currpage + 1].gameObject.SetActive(false);
            }
            if(currpage == 0){
                prevButton.gameObject.SetActive(false); 
                //flipPages[currpage].gameObject.SetActive(true);
            }
            if(currpage - 1 >= 0){
                flipPages[currpage - 1].gameObject.SetActive(true);
            }
            //currpage--;
        }
    }
    public void openBtn_Click(ButtonType typeofButton){
        if(typeofButton == ButtonType.nextButton){
            Debug.Log(currpage + "is flipping");
            flipPages[currpage].nextPage();
            //Debug.Log(currpage + "is flipping");
        }
        else{
            flipPages[--currpage].previousPage();
            Debug.Log(currpage + "is unflipping");
        }
    }
}
