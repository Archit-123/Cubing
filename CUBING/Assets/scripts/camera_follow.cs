using UnityEngine;

public class camera_follow : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    void Update()
    {
        transform.position=player.position + offset;
    }
}
