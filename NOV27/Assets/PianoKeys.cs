using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoKeys : MonoBehaviour
{
    // Start is called before the first frame update


    static bool doorOpen = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (doorOpen)
        {
            Debug.Log("DOOR OPEN TEST");

            FindObjectOfType<fourthDoorController>().doorCheck();
            doorOpen = false;


        }

    }

    static List<int> keyOrder = new List<int>();

    void checkDoor()
    {
        int count = 1;

        for (int i = 0; i < keyOrder.Count; i++)
        {

            if (count == 8)
            {
                doorOpen = true;
            }

            if (keyOrder[i] != count)
            {
                count = 1;
            }
            if (keyOrder[i] == count)
            {
                count++;
            }
            if (count == 8)
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



    public void DO()
    {
        SoundManagerScript.PlaySound("DO");
        keyOrder.Add(1);
        checkDoor();

    }

    public void RE()
    {
        SoundManagerScript.PlaySound("RE");
        keyOrder.Add(2);
        checkDoor();

    }
    public void ME()
    {
        SoundManagerScript.PlaySound("MI");
        keyOrder.Add(3);
        checkDoor();

    }
    public void FA()
    {
        SoundManagerScript.PlaySound("FA");
        keyOrder.Add(4);
        checkDoor();

    }
    public void SOL()
    {
        SoundManagerScript.PlaySound("SOL");
        keyOrder.Add(5);
        checkDoor();

    }
    public void LA()
    {
        SoundManagerScript.PlaySound("LA");
        keyOrder.Add(6);
        checkDoor();
    }
    public void TI()
    {
        SoundManagerScript.PlaySound("TI");
        keyOrder.Add(7);
        checkDoor();

    }

    public void MUSIC_CHECK()
    {
        SoundManagerScript.PlaySound("MUSIC_CHECK");
        checkDoor();

    }


}
