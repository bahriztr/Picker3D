using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    public static Player Instance;

    [SerializeField] private FloatingJoystick joystick;
    [SerializeField] float playerSpeed = 8f;
    float xDir;
    public bool canPlayerMove;

    public float PlayerSpeed { get => playerSpeed; set => playerSpeed = value; }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        transform.position = GameManager.Instance.startPos;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !UIManager.Instance.nextLevelMenu.activeSelf)
            canPlayerMove = true;

        if(canPlayerMove)
            transform.Translate(new Vector3(xDir, 0, 1).normalized * PlayerSpeed * Time.deltaTime);

        xDir = joystick.Horizontal;
    }

    public void SpeedUp()
    {
        playerSpeed = 8f;
    }

    public void SpeedDown()
    {
        playerSpeed = 0f;
    }

    public void ToTargetArea()
    {
        transform.DOMove(new Vector3(GameManager.Instance.startPos.x, 0, GameManager.Instance.startPos.z), 1f);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible") && !BallManager.Instance.BallList.Contains(other.gameObject))
            BallManager.Instance.BallList.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Collectible"))
            BallManager.Instance.BallList.Remove(other.gameObject);
    }
}
