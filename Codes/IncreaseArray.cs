using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseArray : MonoBehaviour
{

    //array, not list
    //public int[] list;

    //list, not array
    //public List<int> List = new List<int>();

    //Array.Resize
    public int[] newList;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ArrayIncrease()
    {

        //Array.Resize(ref newList, newList.Length + 1);
        //newList[newList.Length] = newList.Length;
        int[] temp = new int[newList.Length + 1];
        newList.CopyTo(temp, 0);
        newList = temp;
        newList[newList.Length - 1] = newList.Length - 1;
    }
}