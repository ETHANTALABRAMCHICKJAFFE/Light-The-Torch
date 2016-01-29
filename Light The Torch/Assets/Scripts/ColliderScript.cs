using UnityEngine;
using System.Collections;

public class ColliderScript : MonoBehaviour {

    bool isGameOver = false;
    bool shouldEndGame = false;
    bool isTouchingAnotherBlock = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!isTouchingAnotherBlock)
        {
            shouldEndGame = true;
        }
	}


    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.gameObject.tag == "BlockDetect")
        {
            shouldEndGame = false;
            Debug.Log(shouldEndGame);
            isTouchingAnotherBlock = true;
        }
        else if(other.gameObject.tag == "Player")
        {
            if (shouldEndGame)
            {
                isGameOver = true;
                Constants.GameOver();
            }
        }
        else
        {
            shouldEndGame = true;
        }
    }

    public bool characterInQuicksand;
    void OnTriggerExit2D(Collider2D other)
    {
        isTouchingAnotherBlock = false;
    }



}
