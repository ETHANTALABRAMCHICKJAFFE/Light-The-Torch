using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Constants : MonoBehaviour{

	public static float deltaXBlock = 0.96f; // the delta to add to spawn a new block in X
    public static float deltaYBlock = 0.3f;// the delta to add to spawn a new block in Y
    public static int direction = 1; // for left movement choose 1, for right choose -1;

    public static void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
