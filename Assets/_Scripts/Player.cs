using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    [SerializeField] private FloatingJoystick joystick;
    [SerializeField] float playerSpeed = 8f;
    [SerializeField] float swipeSpeed = 3f;
    float xDir;

    public float PlayerSpeed { get => playerSpeed; set => playerSpeed = value; }

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        xDir = joystick.Horizontal;
        transform.Translate(new Vector3(xDir ,0,1).normalized * PlayerSpeed * Time.deltaTime);
    }
}
