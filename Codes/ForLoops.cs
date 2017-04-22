using UnityEngine;
 
using System.Collections;
 

 
public class ForLoop : MonoBehaviour
 
{
 
  int numEnemies = 3;
 

 
  void Start ()
 
  {
 

 
    for(int i = 0; i < numEnemies; i++)
 
    {
 
      Debug.Log("Creating enemy number: " + i);
 
    }
 
  }
 
}
 

 
/* For loops are similar to whileloops but they use a ifferent syntax.  In this example you can see we have a variable called num enemies. next is the actual loop that uses the syntax. the first section is option and we can use any variables we would like. the next is the conditional whic must be supplied. and the last part we can increase or decrease as we please. 
 
for this code above we are increasin the number of enemies if the number of enemies is less than 3.*/
