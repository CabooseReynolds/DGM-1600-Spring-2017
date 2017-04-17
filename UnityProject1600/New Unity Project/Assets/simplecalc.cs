using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class simplecalc : MonoBehaviour {

    public InputField input1;
    public InputField input2;
    public Text Result;
    //Use this for initialization
    void Start () {

    }

    //Update is called once per frame
    void Update(){

    }

    public void AddButton () {

        int variableWhile;
        variableWhile = int.Parse(input1.text) + int.Parse(input2.text);
        Result.text = variableWhile.ToString();

    }

    public void SubtractButton() {

        int variableWhile;
        variableWhile = int.Parse(input1.text) - int.Parse(input2.text);
        Result.text = variableWhile.ToString();

    }

}