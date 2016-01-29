using UnityEngine;
using System.Collections;

public class BlockScript : MonoBehaviour {
    public bool isMovable = false;
    [SerializeField]
    Transform colliderTopLeft, colliderTopRight;
    [SerializeField]
    float durationToWaitToTurn = 0.5f;
    public int ID = -1;

    void Update()
    {
        checkWhichWayToGo();
    }


    public void checkWhichWayToGo()
    {
        ColliderScript ctl = colliderTopLeft.GetComponent<ColliderScript>();
        ColliderScript ctr = colliderTopRight.GetComponent<ColliderScript>();

        if (!ctl.PlayerTouchedMe && ctl.IsTouchingAnotherBlock)
        {

            GameObject player = GameObject.FindGameObjectWithTag("Player");
            StartCoroutine(setDirectionCR(1, player));
            //int playerDirection = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().PlayerDirection;
            //GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().PlayerDirection = 1;
            //Debug.Log(GameObject.FindGameObjectWithTag("Player"));
        }
        else if(!ctr.PlayerTouchedMe && ctr.IsTouchingAnotherBlock)
        {
            //int playerDirection = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().PlayerDirection;
            //GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().PlayerDirection = -1;
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            StartCoroutine(setDirectionCR(-1, player));
        }
    }

    IEnumerator setDirectionCR(int newDirection,GameObject player)
    {
        int playerDirection;
        Debug.Log(player.transform.name);
        if (player.transform.parent == transform)
       {
            //Debug.Break();
            playerDirection = player.GetComponent<Player>().PlayerDirection;
            yield return new WaitForSeconds(durationToWaitToTurn);
            player.GetComponent<Player>().PlayerDirection = newDirection;
            Debug.Log("new direction" + newDirection);
            //Debug.Break();
        }
    }
}
