using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberController : MonoBehaviour {

	public ParticleSystem numbers;

	//Point value for this number, set externally
	public float numberValue;

	//Set externally, this is the value of the number for your score
	public int scoreValue = 10;
	public int scoreLoseValue;
	public bool useTimer;

	// Use this for initialization
	void Start () {
	if(GameController.gameOver)
				{
					Destroy(gameObject);
				}
	}
	
	// Update is called once per frame
    void Update()
    {
        // how fast he numbers fall
		transform.Translate(Vector3.up * -.5f * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		switch (other.tag)
		{
			case "Checker":

				if(GameController.gameOver)
				{
					SpawnParticle();
					Destroy(gameObject);
				}
				float collNumber = other.gameObject.GetComponent<CheckerController>().number;
				Debug.Log("colliderNumber = " + collNumber);
				if(numberValue == collNumber)
				{
					GameController.score += scoreValue;
					SpawnParticle();
					Destroy(gameObject);
				}
				break;
			case "Ender":
				GameController.score += scoreLoseValue;
				SpawnParticle();
				Destroy(gameObject);
				break;
			default:
				break;
		}
	}

	void SpawnParticle()
	{
		ParticleSystem newParticle = Instantiate(numbers, transform.position, transform.rotation) as ParticleSystem;
		Destroy(newParticle, 1);
	}
}
