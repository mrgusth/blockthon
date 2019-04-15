using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameEnded = false;
    public float restartDelay = 1f;
    public GameObject levelCompleteUI;
    public void GameEnd()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Invoke("Restart", restartDelay);
            
        }
    }

    void Restart()
    {
        //SceneManager.LoadScene("Level01");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //this one loads the next level using its build index.
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name); This one loads the scene too but the last active (implement if multiple tries are tried)
        
    }

    public void CompleteLevel()
    {
        levelCompleteUI.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); this one goes on an scrip in the canvas so it can be called after appearing.
    }
}
