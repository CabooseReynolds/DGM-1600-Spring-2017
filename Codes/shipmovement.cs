using UnityEngine;
 
using System.Collections;
 

 
public class shipmovement : MonoBehaviour {
 

 
    public float moveSpeed;
 

 
    void Start ()
 
    {
 
        moveSpeed = 1f;
 
    }
 

 
    void update ()
 
    { transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed*Input.GetAxis("Vertical")*Time.deltatime);
 
    }
 
}