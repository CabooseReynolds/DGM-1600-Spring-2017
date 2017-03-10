using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour {

    public void LoadLevel(string level){

        SceneManager.LoadScene(level);
    }
}