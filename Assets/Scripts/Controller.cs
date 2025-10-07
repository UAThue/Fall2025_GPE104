using UnityEngine;

public class Controller : MonoBehaviour
{
    public Pawn pawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Based on inputs, send commands to pawn
        MakeDecisions();
    }

    private void MakeDecisions( )
    {
        if ( Input.GetKey(KeyCode.W))
        {
            // Tell Pawn to Move Forward at their own MoveSpeed
            pawn.MoveForward( pawn.moveSpeed );
        }
        if (Input.GetKey(KeyCode.S))
        {
            // Tell Pawn to Move Backward at their own MoveSpeed
            pawn.MoveBackward(pawn.moveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            // Tell Pawn to Rotate Clockwise
            pawn.RotateClockwise(pawn.turnSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            // Tell Pawn to Rotate Clockwise
            pawn.RotateCounterClockwise(pawn.turnSpeed);
        }


    }
}
