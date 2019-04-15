using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Transform playerPosition;
    //public GameManager gameManager;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacles" || playerPosition.position.y < 0.5 )
        {
            movement.enabled = false;
            //GetComponent<PlayerMovement>().enabled = false; Another way to set movement but searching for the component
            FindObjectOfType<GameManager>().GameEnd();
         
        }
    }
}
