using UnityEngine;
using System.Collections;

public class ArrayHomework : MonoBehaviour{

    public string[] zakus;

    void Start () {
       for(int i = 0; i < 10; i++)
        {
           print("Pilot "+ zakus[i]);
        }
      }
}