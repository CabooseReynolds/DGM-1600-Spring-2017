using UnityEngine;
 
using System.Collections;
 
using System;
 

 
public class BadGuy : Icomparable<BadGuy>
 
{
 
    public string name;
 
    public int power;
 

 
    public Badguy (string newName, int newPower)
 
    {
 
        name = newName;
 
        power = newPower;
 
    }
 

 
    public int CompareTo (BadGuy other)
 
    {
 
        if (other == null)
 
        {
 
            return 1;
 
        
 
        }
 
        return power - |
 
    }
 
}
 

 
    /* a list is similar to an array but you do not need to know how many elements you are going to have ahead of time. Since the list is generic you can create this list for use of whatever you would like. 
 
    
 
    for this example, we create a list of badguy traits */
 

 
using UnityEngine;
 
using System.Collections;
 
using System.Collections.Generic;
 

 
public class SomeClass : MonoBehaviour
 
{
 
    void Start ()
 
    {
 
        List<Badguy> badguys = new List<BadGuy>();
 

 
        badguys.Add( new Badguy ("Johnny Ridden", 50));
 
        badguys.Add( new Badguy ("Ramba Ral", 75));
 
        badguys.Add( new Badguy ("Shin Matsunaga", 100));
 

 
            badguys.Sort();
 

 
            foreach (BadGuy guy in badguys)
 
            {
 
                print (guy.name + " " + guy.power)
 
            }
 

 
            //The following clears out the list so that it is empty.
 
            badguys.Clear();
 
    }
 
}
 

 

 

 
using UnityEngine;
 
using System.Collections;
 
using System.Collections.Generic;
 

 
public class SomeOtherClass : MonoBehaviour 
 
{
 
    void Start ()
 
    {
 
        //You can use use two generic terms when you create a Dictionary. In this case I am goign to be using a string and the BadGuy as my two values.
 
        Dictionary<string, BadGuy> badguys = new Dictionary<string, BadGuy>();
 
        
 
        BadGuy bg1 = new BadGuy("Ramba Ral", 75);
 
        BadGuy bg2 = new BadGuy("Johnny Ridden", 50);
 
        
 
        //You are able to place variables into the Dictionary with the () method
 
        
 
        badguys.Add("Gouf Pilot", bg1);
 
        badguys.Add("Zaku II Pilot", bg2);
 
        
 
        BadGuy Johnny Ridden = badguys["Zaku II Pilot"];
 
        
 
        BadGuy temp = null;
 
        
 
        //Alternatively you can use this method of accessing Dictionary values. It is safer, but much slower.
 
        if(badguys.TryGetValue("Gelgoog", out temp))
 
        {
 
            //success!
 
        }
 
        else
 
        {
 
            //failure!
 
        }
 
    }
 
}