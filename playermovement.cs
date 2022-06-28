
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce=2000f;
    public float sideforce = 500f;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0, forwardforce * Time.deltaTime);///add force in z direction2000 times the frame work
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideforce * Time.deltaTime *2, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideforce * Time.deltaTime *2, 0, 0);
        }
       /* if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -sideforce * Time.deltaTime*10);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, sideforce * Time.deltaTime);
        }*/
       if(rb.position.y < -1f)
        {
            FindObjectOfType<gamemanager>().EndGame();
        }
    }
}
