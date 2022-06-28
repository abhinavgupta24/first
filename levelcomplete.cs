using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class levelcomplete : MonoBehaviour
{
    // Start is called before the first frame update
 public void loadnextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
