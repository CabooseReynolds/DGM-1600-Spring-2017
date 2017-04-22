using UnityEngine;
 
using System.Collections;
 

 
public class ForEachLoop : MonoBehaviour
 
{
 
  void Start ()
 
  {
 
        strings[0] = "First String";
 
        strings[0] = "Second String";
 
        strings[0] = "Third String";
 

 
        foreach (string item in strnigs)
 
    {
 
        print (item);
 
  }
 
}
 
}
 

 
/* For loops are userful for iterating through collections. For this loop we have created an array of three strings and  give themsome basic values. 
 
This will list each item of the collection until it has listd each item in the collection atleast once. Using a foreach loop allows us to list a collections 
 
without having to worry about how large the collection may be unlike an array where we would have to list them an stick to that amount of items declared in an array. */
