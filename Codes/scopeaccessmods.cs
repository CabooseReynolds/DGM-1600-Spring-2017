using UnityEngine;
 
using System.Collections;
 

 
public class ScopeAndAccessModifiers : MonoBehaviour
 
/*code blocks are generally what define a variables scope, and these are denoted by braces. 
 
An access modifier is a keyword placed before a data type when declaring the variable and its 
 
purpose is to define where the where the variable or function can be seen from. if other scripts
 
need acces, the script should set to public and can be edited in the inspector. if it doesn't need to be shared anywhere, you want it set to private.*/
 
{
 
    //alpha, beta, gamma are within the scope and access modifiers class
 
    public int alpha = 5;
 
    /* alpha variable can be overwritten in the inspector. while beta and gamma are set to private, if they were left blank, C# would mark them as private by default.*/
 
    private int beta = 0;
 
    private int gamma = 5;
 

 
//the below script would override the change in the inspector.
 
void start()
 
{
 
    alpha = 29;
 
}
 
    //Pens, crayons and answers variables are in scope within the example function 
 
    void Example (int pens, int crayons)
 
    {
 
        int answer;
 
        answer = pens * crayons * alpha;
 
        Debug.Log(answer);
 
    }
 
    
 
    
 
    void Update ()
 
    {
 
        Debug.Log("Alpha is set to: " + alpha);
 
    }
 
}