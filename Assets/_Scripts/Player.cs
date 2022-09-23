using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private FloatingJoystick joystick;
    byte playerSpeed = 4;
    float xDir;

    private void Update()
    {
        xDir = joystick.Horizontal;
        transform.Translate(new Vector3(xDir * 3,0,1) * playerSpeed * Time.deltaTime);
    }
}
