using UnityEngine;
 
using System.Collections;
 

 
public class WhileLoop : MonoBehaviour
 
{
 
    int cupsInTheSink = 4;
 

 
    void Start ()
 
    {
 
        while(cupsInTheSink > 0 )
 
        {
 
            Debug.Log ("I've washed a cup!");
 
            cupsInTheSink--;
 
        }
 
    }
 
}
 

 
/* For this Whileloop code, we have set the number of cups in the sink to 4.  
 
Whe start with the keyword while. IN the parenthesis the code will run while the code comes up as true. 
 
When each action is completed while it is true it will print out the body of the code in this instance it will say "I've washed  cup!" 
 
Then it will run the while loop again, decreasing the number of cups till it has run enough till the number of cups in the sink equals zero. */
 

 
// Here is another example of a WhileLoop
 

 
public class WhileLoop : MonoBehaviour
 
{
 
    int shirtsToFold = 9;
 

 
    void Start ()
 
    {
 
        while(shirtsToFold > 0 )
 
        {
 
            Debug.Log ("I've folded a shirt!");
 
            shirtsToFold--;
 
        }
 
    }
 
}