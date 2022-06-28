
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    bool gamehasended = false;
    public float restartdelay = 1f;
    public GameObject completelevelui;

    public void completelevel()
    {
        {
            completelevelui.SetActive(true);
        }
    }
    // Start is called before the first frame update
    public void EndGame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("game over");
            //restart
            Invoke("restart", restartdelay);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}