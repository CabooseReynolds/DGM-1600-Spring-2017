using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {

	//use of list for using more than 2 numbers

	public Text outputText;
	private float sum = 0;

	public float num1 = 0;
	public float num2 = 0;

	public static float total;

	private string lastFunction = "Start";

	//Enabled or disabled depending on criteria of the game
	public Button multiplyButton;
	public Button divideButton;
	public Button digitOneButton;
	public Button equalsButton;

	// Use this for initialization
	void Start () {
		outputText.text = "0";	
	}
	
	// Update is called once per frame
	void UpdateText () {
		outputText.text = sum.ToString();
	}

	public void AddDigit(float digit)
	{
/*	{

		if(opperatorPressed)
		{
			num1 = 0;
			num2 = (num2 * 10) + digit;
			sum = num2;
			opperatorPressed = false;
			lastFunction = "Start";
		}
		else
		{
			num2 = (num2 * 10) + digit;
			sum = num2;
		}

		UpdateText();
	} 
	
	The above has been removed in order to apply new controls to the calculator to give it more functionality during game rather than being a simple 10 digit calculator */
	digitOneButton.interactable = true;

	//stacks digits so you can create larger numbers rather than being individual digits in an equation
	num2 = (num2 * 10) + digit;
	sum = num2;
//more checks for what buttons should be enabled/disabled in the game so that the game isn't easy
		if((digit == 1 && sum < 10) || sum % 10 == 0)
		{
			multiplyButton.interactable = false;
			divideButton.interactable = false;
		}
		else
		{
			multiplyButton.interactable = true;
			divideButton.interactable = true;
		}
		if((digit == 1 || sum % 10 == 0) && (lastFunction == "Multiply" || lastFunction == "Divide"))
		{
			equalsButton.interactable = false;
		}
		else
		{
			equalsButton.interactable = true;
		}
		UpdateText();
}
	public void AddButton ()
	{
	//sets the output text to say + so we know that we pressed the + button
		outputText.text = "+";
		Function();
		lastFunction = "Add";
		Debug.Log(lastFunction);
	}

	public void SubtractButton ()
	//same as Addbutton but with Subtraction
	{
		outputText.text = "-";
		Function();
		lastFunction = "Subtract";
		Debug.Log(lastFunction);
	}

	public void MultiplyButton ()
	{
	//same as Addbutton but with Multiplication
		outputText.text = "*";
		Function();
		lastFunction = "Multiply";
		Debug.Log(lastFunction);
	}

	public void DivideButton ()
	{
	//same as Addbutton but with Division
		outputText.text = "/";
		Function();
		lastFunction = "Divide";
		Debug.Log(lastFunction);
		digitOnebutton.interactable = false;
	}

	public void EqualButton ()
	{
		//changed function of the equalbutton from a switch to last function.
		Function(); 
		sum = num1;

		if(lastFunction != "Start")
		{
			total = sum;
		}
		lastFunction = "Start";

		UpdateText();
	}
		/* switch (lastFunction)
		{
			case "Add":
				sum = num1 + num2;
				num1 = sum;
				num2 = 0;
				UpdateText();
				break;
			case "Subtract":
				sum = num1 - num2;
				num1 = sum;
				num2 = 0;
				UpdateText();
				break;
			case "Multiply":
				sum = num1 * num2;
				num1 = sum;
				if(num2 == 0
				{
					total = 0;
				}
				else
				{
					total = sum;
				}
				num2 = 0;
				UpdateText();
				break;)
			case "Divide":
				sum = num1 / num2;
				num1 = sum;
				if(num2 == 0)
				{
					total = 0;
				}
				else
				{
					total = sum;
				}
				num2 = 0;
				UpdateText();
				break;
			default:
				Debug.Log("No lastFunction set");
				break;
		}
		opperatorPressed = true;
		lastFunction = "Equals";
	} */

	public void ClearButton ()
	{
		num1 = 0;
		num2 = 0;
		sum = 0;
		opperatorPressed = false;
		lastFunction = "Start";
		UpdateText();
	}

	public void Function ()
	{
		switch (lastFunction)
		{
			case "Add":
				num1 = num1 + num2;
				num2 = 0;
				//lastFunction = "Add";
				break;
			case "Subtract":
				num1 = num1 - num2;
				num2 = 0;
				//lastFunction = "Subtract";
				break;
			case "Multiply":
				num1 = num1 * num2;
				num2 = 0;
				//lastFunction = "Multiply";
				break;
			case "Divide":
				num1 = num1 / num2;
				num2 = 0;
				//lastFunction = "Divide";
				break;
			case "Start":
				num1 = num2;
				num2 = 0;
				break;
			default:
				Debug.Log("No lastFunction set");
				break;
		}
	}
}