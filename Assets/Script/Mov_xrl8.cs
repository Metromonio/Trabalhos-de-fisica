using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_xrl8 : MonoBehaviour
{
    
    public Vector3 velocity;

    public Vector3 accleration;

    void FixedUpdate()
    {
        UpdateVelocity();

        transform.position = new Vector3(
            CalculatePosition(transform.position.x), transform.position.y, transform.position.z);
    }

    private float CalculatePosition(float positionX)
    {
        return positionX + velocity.x * Time.deltaTime;
    }

    private void UpdateVelocity()
    {
        velocity += accleration * Time.deltaTime;
    }
}