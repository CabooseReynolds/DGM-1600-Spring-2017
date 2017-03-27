using UnityEngine;
using System.Collections;

public class ArrayHomework3 : MonoBehaviour{

    public string[] zakus;

    void Start () {
       for(int i = 0; i < 10; i++)
        {
           print("Pilot "+ zakus[i]);
        }
      }
}