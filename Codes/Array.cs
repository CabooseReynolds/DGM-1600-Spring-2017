using UnityEngine;
using System.Collections;

public class Array : MonoBehaviour{

    public string[] friends= {"Bob","sue","Ted","Rufio"};

    void Start () {
       for(int i = 0; i < friends.Length; i++)
        {
           print("Hello "+ friends[i]);
        }
      }
}

/* Arrays are a way of storing a collection of data of the same type together.

Fo example, you can store multiple sets of integers in an array instead of having to write them out individually. 

Array is not a type but a collection of variables of a certain type. 

Elements are called items in an array.

You want to declare the number of elements in the array.
If you leave the declared number blank, you can add as many as you want. but if you declare how many there are, you cannot have less or more.

You can either declare number of elements or you can declare them using values instead.

If you make an array public you can see it in the inspector and allocate values to it. 

You can assign these arrays to gameobjects. 

That way you can see all objects when the console is run. */

using UnityEngine;
using System.Collections;

public class Array : MonoBehaviour{

    public string[] zakus= {"Zaku 1","Zaku 2J","Zaku 2F","Zaku 2R-1"};

    void Start () {
       for(int i = 0; i < zakus.Length; i++)
        {
           print("Pilot "+ zaku[i]);
        }
      }
}