using UnityEngine;

public class CirclePatrol : MonoBehaviour
{
    public Vector3 startPoint; // Starting point of the circle
    public Vector3 endPoint; // End point of the circle
    public float speed = 1.0f; // Speed at which the circle moves
    private Vector3 targetPosition; // Target position to move to
    private float timer; // Timer to control when to change direction
    private bool directionChanged; // Flag to check if direction has changed

    // Start is called before the first frame update
    void Start()
    {
        // Set the target position to the end point
        targetPosition = endPoint;
        // Set the directionChanged flag to false
        directionChanged = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the circle towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // If the circle reaches the target position, change direction
        if (Vector3.Distance(transform.position, targetPosition) <= 0.1f)
        {
            // If the direction hasn't changed yet, change the target position and set the flag
            if (!directionChanged)
            {
                directionChanged = true;
                targetPosition = startPoint;
            }
            // Reset the timer
            timer = Vector3.Distance(startPoint, endPoint) / speed;
        }

        // Increase the timer
        timer -= Time.deltaTime;

        // If the timer reaches 0, change direction again
        if (timer <= 0)
        {
            // Reset the timer
            timer = Vector3.Distance(startPoint, endPoint) / speed;
            // If the direction has changed, set the target position to the end point
            if (directionChanged)
            {
                targetPosition = endPoint;
            }
        }
    }

    // This function is called when the MonoBehaviour will be destroyed
    void OnDestroy()
    {
        // Reset the directionChanged flag when the object is destroyed
        directionChanged = false;
    }
}