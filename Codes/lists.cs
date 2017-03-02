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

public class Lists : MonoBehaviour
{
    void Start ()
    {
        List<Badguy> badguys = new List<BadGuy>();

        badguys.Add( new Badguy ("Johnny Ridden", 50));
        badguys.Add( new Badguy ("Ramba Ral", 75));
        badguys.Add( new Badguy ("Char", 100));

            badguys.Sort();

            foreach (BadGuy guy in badguys)
            {
                print (guy.name + " " + guy.power)
            }
            badguys.Clear();
    }
}