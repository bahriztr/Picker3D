using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private FloatingJoystick joystick;
    [SerializeField] byte playerSpeed = 8;
    [SerializeField] byte swipeSpeed = 3;
    float xDir;

    private void FixedUpdate()
    {
        xDir = joystick.Horizontal;
        transform.Translate(new Vector3(xDir * 3,0,1) * playerSpeed * Time.deltaTime);
    }
}
