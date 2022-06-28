
using UnityEngine;

public class followplayer : MonoBehaviour
{
    public Transform players;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = players.position + offset;
    }
}
