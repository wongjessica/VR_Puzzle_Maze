using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonBlue : MonoBehaviour




// create list to track order of input recieved 

// run a loop thorugh the list to see if a certain order is achieved (1,2,3,4,5)




{

    static bool doorOpen = false;
   // public RiddleDoorController door;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        if (doorOpen)
        {
            Debug.Log("DOOR OPEN TEST");
           
            FindObjectOfType<RiddleDoorController>().doorCheck();
            doorOpen = false;
           

        }


    }

    


    static List<int> doorOrder = new List<int>();





    void checkDoor()
    {
        int count = 1;

        for (int i = 0; i < doorOrder.Count; i++)
        {

            if(count == 6)
            {
                doorOpen = true;
            }

            if (doorOrder[i] != count)
            {
                count = 1;
            }
            if (doorOrder[i] == count)
            {
                count++;
            }
            if (count == 6)
            {
                doorOpen = true;
            }

           
            

            Debug.Log("THE COUNT IS " + count);



        }

        if (doorOpen == true)
        {
            Debug.Log("DOOR OPEN");
        }

    }


    void doorOrderLog()
    {
      
        for (int i = 0; i < doorOrder.Count; i++)
        {

            Debug.Log(doorOrder[i]);
        }
      

    }

    public void firstButtonPressed()
    {
        doorOrder.Add(1);
        Debug.Log("First Button Pressed");
        //doorOrderLog();
        checkDoor();

    }
    public void secondButtonPressed()
    {
        doorOrder.Add(2);
        Debug.Log("Second Button Pressed");
        //doorOrderLog();
        checkDoor();
    }
    public void thirdButtonPressed()
    {
        doorOrder.Add(3);
        Debug.Log("Third Button Pressed");
        //doorOrderLog();
        checkDoor();
    }
    public void fourthButtonPressed()
    {
        doorOrder.Add(4);
        Debug.Log("Fourth Button Pressed");
        //doorOrderLog();
        checkDoor();
    }
    public void fifthButtonPressed()
    {
        doorOrder.Add(5);
        Debug.Log("Fifth Button Pressed");
        //doorOrderLog();
        checkDoor();
    }


}



