using UnityEngine;

public class PlayerDisappearance : MonoBehaviour
{
    // Called when another collider enters a trigger collider attached to this object
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player collides with the rectangle
        if (other.CompareTag("Rectangle"))
        {
            // Deactivate the player GameObject
            gameObject.SetActive(false);
        }
    }
}
