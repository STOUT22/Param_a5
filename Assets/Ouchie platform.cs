using UnityEngine;

public class ReturnToStartPlatform : MonoBehaviour
{
    public Transform startingPoint; // Assign the starting point transform in the Inspector

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Reset player position to the starting point
            collision.transform.position = startingPoint.position;
        }
    }
}
