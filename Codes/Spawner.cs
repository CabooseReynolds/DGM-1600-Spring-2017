using UnityEngine;
using System.Collections;

public class Spawner : Monobehaviour {

    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;

    int randEnemy;

void Start () 
{

}

Void Update () 
{

}

IEnumberator waitSpawner()
{
    yield return new WaitForSeconds (startWait):

    while(!stop)
    {
        randEnemy = Random.Range (0, 10):

        Vector3 spawnPosition = new Vector3 (Randm.Range (-spawnValues.x, spawnValues.X), 1, )
    }
}
}