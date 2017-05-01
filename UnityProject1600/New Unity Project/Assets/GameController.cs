using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{


    // Stuff for the timer
    public Text timerText;
    public float timerStartTime;
    float timerTime;
    //Checks incerments of time in intervals of 5 for use of Numbers spawn
    public float timerCheckTime = 5;
    public static float score = 0;
    //Array set up for number spawn at random
    public NumberController[] numbers;
    public Transform numberSpawn;
    public CheckerController checker;
    public Transform checkerSpawn;
    public Text scoreText;
    public Text scoreText2;
    public Image gameOverScreen;
    private bool spawned = false;
    public Text gameOverText;
    public static bool gameOver = false;
    private bool restart;
//    public float spawnTime = 5f;        // The amount of time between each spawn.
//    public float spawnDelay = 3f;       // The amount of time before spawning starts.  
// The following commented codes are to get the game to randomly spawn between two set numbers.
	public float spawnWait;
	public float spawnMostWait;
	public float spawnLeastWait;
    public int startWait;

    // Use this for initialization
    void Start()
    {
        timerTime = timerStartTime;
        Invoke("SpawnNumber", 1);
        //allows game to restart timer and score. Waits for the code to be activated in order to trigger game over or the restart feature.
        gameOver = false;
        restart = false;
//		StartCoroutine(SpawnNumber());
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            //GameOver();
        }
         if (restart) 
         {
                 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
             }
        else
        {
            Timer();
            UpdateScore();
        }
/*		{
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    } */

    //following resets score on game screen.
    }
    public static void ResetPoints()
{
    score = 0;
}
void Awake()
{
    score = 0; //Also the score here
    GameController.ResetPoints(); 
}

    void SpawnNumber()
    {
        Debug.Log("Number Spawned");
        float number;
        int firstDigit;
        int secondDigit;
        number = RandomNumber();
        //number = Random.Range(1, 99);
        Debug.Log(number);
        //if number was 78 firstDigit would be 8, secondDigit would be 7
        firstDigit = Mathf.RoundToInt(number % 10);
        secondDigit = Mathf.RoundToInt(Mathf.Floor(number / 10));

        // Used for spawning numbers 
        NumberController newDigit;
	// spawns between 2 points of my number spawner bar.
        float xSpawn = Random.Range(.5f, 8.5f);
         // if (!gameOver)

      {Invoke("SpawnNumber", spawnWait = Random.Range(spawnLeastWait, spawnMostWait));}

        newDigit = Instantiate(numbers[firstDigit], new Vector3(xSpawn + .225f, numberSpawn.position.y, numberSpawn.position.z), numberSpawn.rotation);
        newDigit.numberValue = number;

        if (secondDigit != 0)
        {
            newDigit = Instantiate(numbers[secondDigit], new Vector3(xSpawn + -.225f, numberSpawn.position.y, numberSpawn.position.z), numberSpawn.rotation);
            newDigit.numberValue = number;
        }

    }

    public void CheckNumber()
    {

        //Checker should only spawn when you hit the equal
        CheckerController newChecker = Instantiate(checker, checkerSpawn.position, checkerSpawn.rotation) as CheckerController;
        newChecker.number = Calculator.total;
 }
 //Following is to restart the scene, but it doesn't work with the current game coding setup.
  /*    public void reloadCurrentScene() {
     Scene loadedLevel = SceneManager.GetActiveScene ();
     SceneManager.LoadScene (loadedLevel.buildIndex);
         Time.timeScale = 1;
     } */
    void Timer()
    {
        //decreases time on the timer
        timerTime -= Time.deltaTime;
        // displays the current time rounded down
        timerText.text = "Timer: " + Mathf.FloorToInt(timerTime).ToString("f0");

        //if the timer hits zero game is over. Due to the way the time is, anything less than 1 is technically Zero due to rounding down the current time.

        if (timerTime <= 1)
        {
            gameOver = true;
            spawned = true;
            GameOver();
        }

        if (Mathf.Floor(timerTime % timerCheckTime) == 0 && spawned == false)
        {
            Debug.Log(timerTime);
           // SpawnNumber();
            //sets spawned to true so it only spawns one object
            spawned = true;
            Debug.Log(spawned);
        }
        else if (Mathf.FloorToInt(timerTime % timerCheckTime) != 0)
        {
            spawned = false;
        }


    }
    public bool IsPrime(float number)
    {
        //Folowing is set up to avoid prime numbers
        if (number == 1) return false;
        if (number == 2) return true;

        if (number % 2 == 0) return false;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0) return false;
        }

        return true;
    }

    public float RandomNumber()
    {
        float newNumber = Random.Range(1, 99);
        if (IsPrime(newNumber))
        {
            return RandomNumber();
        }
        else
        {
            return newNumber;
        }
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + score.ToString();
        scoreText2.text = "Final Score: " + score.ToString();
    }
    

    public void GameOver()
    {
        timerText.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(false);
        //gameOverText.gameObject.SetActive(true);
        gameOverScreen.gameObject.SetActive(true);
        scoreText2.gameObject.SetActive(true);
        CheckNumber(); 
    }

    public void ChangeScene(string sceneName)
    {
        gameOver = false;
        spawned = true;
    }
}
