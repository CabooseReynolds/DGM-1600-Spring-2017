using UnityEngine;
 
using System.Collections;
 

 
public class Arraystest : MonoBehaviour{
 

 
    public string[] friends= {"Bob","sue","Ted","Rufio"};
 

 
    void Start () {
 
       for(int i = 0; i < friends.Length; i++)
 
        {
 
           print("Hello "+ friends[i]);
 
        }
 
      }
 
}