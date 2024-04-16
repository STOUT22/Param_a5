using UnityEngine;

public class CirclePatrol : MonoBehaviour
{
    public Vector3 startPoint; // Starting point of the circle
    public Vector3 endPoint; // End point of the circle
    public float speed = 1.0f; // Speed at which the circle moves
    private Vector3 targetPosition; // Target position to move to

    // Start is called before the first frame update
    void Start()
    {
        // Set the target position to the end point
        targetPosition = endPoint;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the circle towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // If the circle reaches the target position, change direction
        if (Vector3.Distance(transform.position, targetPosition) <= 0.1f)
        {
            // Change the target position based on the current direction
            if (targetPosition == startPoint)
                targetPosition = endPoint;
            else
                targetPosition = startPoint;
        }
    }
}
