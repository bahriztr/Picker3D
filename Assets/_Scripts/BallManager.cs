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

    public void BlastAllBalls()
    {
        foreach (GameObject ball in ballList)
        {
            ball.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    public void PushBalls()
    {
        foreach(GameObject ball in ballList)
        {
            ball.transform.DOMove(new Vector3(ball.transform.position.x + Random.Range(-1f, 1f), ball.transform.position.y, ball.transform.position.z + Random.Range(5f, 7f)), 0.2f);
        }
    }

}
