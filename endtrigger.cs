
using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public gamemanager gamemanager;
    void OnTriggerEnter ()
    {
        gamemanager.completelevel();

    }
}
