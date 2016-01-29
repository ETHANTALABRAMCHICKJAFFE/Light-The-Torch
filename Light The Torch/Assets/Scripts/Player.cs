using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    float playerVX = 0.96f*5;
    float playerVY = 0.3f*5;
    int playerDirection = 1; // 1 means left, -1 means right
    public int currentBlockID = -1;
    public int PlayerDirection
    {
        get
        {
            return playerDirection;
        }

        set
        {
            playerDirection = value;
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Constants.deltaXBlock);
        Vector2 playerVelocity = new Vector2(playerVX * -playerDirection, playerVY);
        GetComponent<Rigidbody2D>().velocity = playerVelocity;
    }

}
