using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour
{
    //long hand Arrays
    int[] myIntArray = new int [5];

    void Start ()
    {
        myIntArray[0] = 12;
        myIntArray[1] = 76;
        myIntArray[2] = 8;
        myIntArray[3] = 937;
        myIntArray[4] = 903;
    }
}

//quick Arrays
public class Arrays : MonoBehaviour
{
    int [] myIntArray = {12, 76, 8, 937, 903};

    void Start ()
    {
        myIntArray[4] = 57;
    }
}

//assigning players to an array
public class Arrays : MonoBehaviour
{
    public GameObject[] players;

    void Start ()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        // you can start a for statement as well
        for(int i = 0; i < player.length; i++)
        {
            Debug.Log("Player Number "+i+" is named "+players[i].num);
        }
    }
}