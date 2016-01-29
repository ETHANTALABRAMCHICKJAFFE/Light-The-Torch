using UnityEngine;
using System.Collections;

public class TurnColliderScript : MonoBehaviour {

    public int newDirection = 1; // 1 means left, -1 means right.

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Player>().PlayerDirection = newDirection;
            if (newDirection == 1)
                other.gameObject.GetComponent<Animator>().SetBool("Left", true);
            else
                other.gameObject.GetComponent<Animator>().SetBool("Left", false);
        }
    }
}
