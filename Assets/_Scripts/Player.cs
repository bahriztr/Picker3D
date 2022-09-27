using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    [SerializeField] private FloatingJoystick joystick;
    [SerializeField] float playerSpeed = 8f;
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

    public void SpeedUp()
    {
        playerSpeed = 8f;
    }

    public void SpeedDown()
    {
        playerSpeed = 0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Collectible"))
            BallManager.Instance.BallList.Add(other.gameObject);

        if (other.CompareTag("FirstPath"))
            GameManager.Instance.FirstPathPlacement();
        else if (other.CompareTag("SecondPath"))
            GameManager.Instance.SecondPathPlacement();
        else if (other.CompareTag("ThirdPath"))
            GameManager.Instance.ThirdPathPlacement();
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Collectible"))
    //        BallManager.Instance.BallList.Remove(other.gameObject);
    //}
}
