using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

	public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            SceneManager.LoadScene("Gameover");
            // Debug.Log("GAME OVER");
            //  Invoke("Restart", restartDelay);
        }
    }
    //void Restart()
   // {
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   // }
}

