using UnityEngine;
using System.Collections;

public class ArrayHomework4 : MonoBehaviour{
 
public static ArrayList _gameObjects;
 
void Start () {
   
        _gameObjects = new ArrayList();
}
 
void AddNewObject(){
 
        GameObject _tempObject;
        _tempObject = new GameObject(_tempName);
        _gameObjects.Add(_tempObject);
}
}
 