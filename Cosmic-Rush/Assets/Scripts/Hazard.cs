using UnityEngine;

public class TeleportOnCollision : MonoBehaviour
{
    public Vector3 teleportPosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = teleportPosition;
        }
    }
}