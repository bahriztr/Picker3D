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
            ball.gameObject.SetActive(false);
        }
    }

    public void PushBalls()
    {
        foreach (GameObject ball in ballList)
        {
            ball.transform.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-5f,5f),0,Random.Range(12f,16f));
        }
    }

}
