using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BallManager : MonoBehaviour
{
    public static BallManager Instance;

    public List<GameObject> ballList = new List<GameObject>();

    public List<GameObject> BallList { get => ballList; set => ballList = value; }

    private void Awake()
    {
        Instance = this;
    }

    public void PushBalls()
    {
        foreach(GameObject ball in ballList)
        {
            ball.transform.DOMoveZ(ball.transform.position.z + Random.Range(5f, 7f), 0.5f);
        }
    }


}
