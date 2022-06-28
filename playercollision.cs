
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playermovement movement;  //reference to our player movement script
      
    //function run when we hit any object
   void OnCollisionEnter(Collision collisioninfo )
    {
        //checking if we collided or not
        if(collisioninfo.collider.tag == "obstacle")
        {
            movement.enabled = false;  //disable player movement
            FindObjectOfType<gamemanager>().EndGame();
        }
    }
}
