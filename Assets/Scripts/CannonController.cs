using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public float rotationSpeed;
    public float xDegrees, yDegrees;
    
    public Transform cannonBody;
    void Update()
    {
        CannonMovement();
    }

    void CannonMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        xDegrees += horizontalInput * rotationSpeed * Time.deltaTime;
        yDegrees += verticalInput * rotationSpeed * Time.deltaTime;

        xDegrees = Mathf.Clamp(xDegrees, -50, 50);
        yDegrees = Mathf.Clamp(yDegrees, -5, 50);

        cannonBody.localEulerAngles = new Vector3(yDegrees, xDegrees, 0);

    }
}
