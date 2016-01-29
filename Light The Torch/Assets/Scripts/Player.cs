using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    float playerVX = 0.96f;
    float playerVY = 0.3f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Constants.deltaXBlock);
        Vector2 playerVelocity = new Vector2(playerVX * -Constants.direction, playerVY);
        Debug.Log(playerVelocity);
        GetComponent<Rigidbody2D>().velocity = playerVelocity;
	}

}
