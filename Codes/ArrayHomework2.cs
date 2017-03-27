using UnityEngine;
using System.Collections;

public class ArrayHomework2 : MonoBehaviour{

    public string[] zakus;

    void Start () {
       for(int i = 0; i < zakus.length; i++)
        {
           print("Pilot "+ zakus[i]);
        }
      }
}