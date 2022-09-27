using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo) //runs every time the object this script is under (the player) collides with something. Collision collisionInfo stores any info about what the object colided with
    {
        if (collisionInfo.collider.tag == "Obstacle") //checks if the name of what we colided with is "Obstacle"
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
