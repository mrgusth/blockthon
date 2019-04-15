using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform rb1;
    public Transform player;
    public float sideWaysForce = 4f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame. fixed is better to handle collisions
    void FixedUpdate()
    {

        if (rb1.position.z -player.position.z < 30)
        {
            if (rb1.position.x <= 4)
            {
                rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (rb1.position.x > 4)
            {
                rb.ResetInertiaTensor();
                rb.AddForce(-(100*sideWaysForce) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

            }


            /* if (rb1.position.x <= -4)
             {
                 if (rb1.position.x <= 3)
                 {
                     rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                 }

                 if (rb1.position.x > 0)
                 {
                     rb.ResetCenterOfMass();
                     rb.AddForce(-(sideWaysForce) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

                 }
             }
             else if (rb1.position.x >= 4)
             {
                 if (rb1.position.x <= -3)
                 {
                     rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                 }

                 if (rb1.position.x < 0)
                 {
                     rb.ResetCenterOfMass();
                     rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

                 }
             } */
        }
    
           
      
        
    }
}
