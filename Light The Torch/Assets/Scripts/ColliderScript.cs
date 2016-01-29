using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//[ExecuteInEditMode]
public class ColliderScript : MonoBehaviour
{

    bool isGameOver = false;
    bool shouldEndGame = true;
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
            IsTouchingAnotherBlock = true;
        }
        else if (other.gameObject.tag == "Player")
        {
            PlayerTouchedMe = true;
            if (shouldEndGame)
            {
                isGameOver = true;
                GameOver();
            }
        }
        else
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
            IsTouchingAnotherBlock = false;
    }


    public static void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
