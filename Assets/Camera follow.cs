using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    public float cameraFollowSpeed = 2f; // Adjust as needed

    void Update()
    {
        if (playerTransform != null)
        {
            // Camera follow
            Vector3 targetPosition = new Vector3(transform.position.x, playerTransform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, cameraFollowSpeed * Time.deltaTime);
        }
    }
}
