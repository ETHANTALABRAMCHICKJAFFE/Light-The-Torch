using UnityEngine;
using System.Collections;

public class TurnColliderScript : MonoBehaviour {

    public int newDirection = 1; // 1 means left, -1 means right.
    public Transform colliderPointingLeft, colliderPointingRight;

    void Update()
    {
        if (colliderPointingLeft.GetComponent<ColliderScript>().isTouchingAnotherBlock)
        {
            newDirection = 1;
        }
        else if (colliderPointingRight.GetComponent<ColliderScript>().isTouchingAnotherBlock)
        {
            newDirection = -1;
        }else if (!colliderPointingRight.GetComponent<ColliderScript>().isTouchingAnotherBlock
            && !colliderPointingLeft.GetComponent<ColliderScript>().isTouchingAnotherBlock)
        {
            newDirection = 0;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (newDirection == 1)
                other.gameObject.GetComponent<Animator>().SetBool("Left", true);
            else if (newDirection == -1)
                other.gameObject.GetComponent<Animator>().SetBool("Left", false);
            else if (newDirection == 0)
                ColliderScript.GameOver();
            other.gameObject.GetComponent<Player>().PlayerDirection = newDirection;
           
        }
    }
}
