using UnityEngine;

public class CarCollision : MonoBehaviour {

    public Ride movement;
    public GyroMove mov;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle" )
        {
            //Debug.Log("Matei");
            movement.enabled = false;

            FindObjectOfType<AudioManager>().Play("Batida");
            FindObjectOfType<GameManager>().EndGame();


        }
    }
}

