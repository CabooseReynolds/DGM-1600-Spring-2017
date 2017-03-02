using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour
{
    void Start ()
    {
        bool shouldContinue = false;

        do
        {
            print ("Hello World");
        
        }while (shouldContinue == true);
    }
}

/* For this Do-Whileloop code, Do-while loops are similar to Whileloops with one major difference. Whileloops check the condition of the loop at the eginning of the code, do-while loops check the status at the end of the loop. This guarantees that the code will run atleast once.*/

// Here is another example of a DoWhileLoop

public class DoWhileLoop : MonoBehaviour
{
    void Start ()
    {
        bool shouldContinue = false;

        do
        {
            print ("Homework is fun");
        
        }while (shouldContinue == true);
    }
}