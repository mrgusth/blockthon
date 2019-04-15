using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f; //the f in the number represents the float, it helps unity understand it better.
    public float sideWaysForce = 80f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame. fixed is better to handle collisions
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Time.deltaTime reduces movement speed by the count between frames.

        if ( Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if ( Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if ( rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameEnd();
        }

    }
}
