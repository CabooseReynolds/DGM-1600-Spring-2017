using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

    //Use this for initilization
    void Start () {
        string light = "Green";

        switch(light){
                case "red":
                    print("the light is red -- Stop!!!");
                break;
                case "yellow":
                    print("the light is yellow -- Slow down!");
                break;
                case "Green":
                    print("the light is green -- Go!!!");
                break;
                default:
                    print("that is not a valid color!");
                  break;
        }
    }
}