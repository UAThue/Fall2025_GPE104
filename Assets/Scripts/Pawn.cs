using UnityEngine;

public class Pawn : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    public float turnSpeed;

    [Header("Components")]
    public Health health;
    public Death death;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Load the health component from this object
        health = GetComponent<Health>();

        // Load the Death component
        death = GetComponent<Death>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveForward ( float moveSpeed )
    {
        // Change my pawn's position -- in the forward direction, magnitude of moveSpeed
        // Get the transform component
        transform.position = transform.position + ( (transform.up * moveSpeed) * Time.deltaTime);
    }

    public void MoveBackward(float moveSpeed)
    {
        transform.position = transform.position + (-transform.up * moveSpeed * Time.deltaTime);
    }

    public void RotateClockwise ( float rotateValue )
    {
        transform.Rotate(0.0f, 0.0f, rotateValue * Time.deltaTime);
    }

    public void RotateCounterClockwise(float rotateValue)
    {
        transform.Rotate(0.0f, 0.0f, -rotateValue * Time.deltaTime);
    }
}
