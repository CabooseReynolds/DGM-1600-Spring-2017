using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour  {

    /*
Streamlined conditional to compare a single variable to a series of constants
make decisions based on enumerations
Characters conversation options based on their intelligence
You could use if else statemtents but they become combersome, if you start checking for more than 2 conditions, you want to use switch statements.
you have to start the command with "Switch" then followed by the integer.
then define a series of cases. include as many as needed
then create a jump statement by using "break" this will stop the code from going through the rest of the cases.*/

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