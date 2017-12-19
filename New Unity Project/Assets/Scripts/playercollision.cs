using UnityEngine;

public class playercollision : MonoBehaviour{

    public player_move movement;

    public Rigidbody rb;

    public float boostForce = 10000f;

    void OnCollisionEnter  (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

        if (collisionInfo.collider.tag == "Boost")
        {
            rb.AddForce(0, 0, boostForce * Time.deltaTime);
        }
    }
}