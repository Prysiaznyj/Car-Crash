using UnityEngine;

public class EndT : MonoBehaviour {

	public GameManager gameManager;

    void OnTriggerEnter()
    {
        FindObjectOfType<AudioManager>().Play("End");
        gameManager.CompleteLevel();
    }
}


