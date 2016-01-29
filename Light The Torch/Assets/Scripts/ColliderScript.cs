using UnityEngine;
using System.Collections;

//[ExecuteInEditMode]
public class ColliderScript : MonoBehaviour
{

    bool isGameOver = false;
    bool shouldEndGame = false;
    //[SerializeField]
    //Transform parent;
    public bool isTouchingAnotherBlock = false;

    bool playerTouchedMe = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!IsTouchingAnotherBlock)
        {
            shouldEndGame = true;
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "BlockDetect")
        {
            shouldEndGame = false;
            Debug.Log(shouldEndGame);
            IsTouchingAnotherBlock = true;
        }
        else if (other.gameObject.tag == "Player")
        {
            PlayerTouchedMe = true;
            other.gameObject.transform.SetParent(transform.parent);
            if (shouldEndGame)
            {
                isGameOver = true;
                Constants.GameOver();
            }
        }
        else if(other.gameObject.tag != "BlockObject")
        {
            shouldEndGame = true;
        }
    }

    public bool PlayerTouchedMe
    {
        get
        {
            return playerTouchedMe;
        }

        set
        {
            playerTouchedMe = value;
        }
    }

    public bool IsTouchingAnotherBlock
    {
        get
        {
            return isTouchingAnotherBlock;
        }

        set
        {
            isTouchingAnotherBlock = value;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        //if (other.gameObject.tag == "DetectBlock")
            IsTouchingAnotherBlock = false;
    }



}
