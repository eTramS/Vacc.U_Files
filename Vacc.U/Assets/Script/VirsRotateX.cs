using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirsRotateX : MonoBehaviour
{
    public Transform RotationC;
    public float AngularSpeed, RotationRadius;
     float pX, pY, angle = 0;
    public void Update()
    {
        pX = RotationC.position.x + Mathf.Cos(angle) * RotationRadius;
        pY = RotationC.position.y + Mathf.Sin(angle) * RotationRadius;
        transform.position = new Vector2(pX, pY);
        angle = angle + Time.deltaTime * AngularSpeed;

        if (angle >= 360)
        {
            angle = 0;
        }

    }
}
