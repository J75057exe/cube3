using UnityEngine;

public class playercollision : MonoBehaviour{

    public player_move movement;


    void OnCollisionEnter  (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}