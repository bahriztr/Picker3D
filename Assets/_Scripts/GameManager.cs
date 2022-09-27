using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject[] firstPathArray, secondPathArray, thirdPathArray;

    public Transform firstPathTransform, secondPathTransform, thirdPathTransform;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        firstPathTransform = firstPathArray[0].transform;
        secondPathTransform = secondPathArray[0].transform;
        thirdPathTransform = thirdPathArray[0].transform;
        //90 arttýr.
    }

    public void FirstPathPlacement()
    {
        GameObject go = firstPathArray[Random.Range(0, 10)];
        go.SetActive(true);
        go.transform.position = firstPathTransform.position + new Vector3(0, 0, 270);
    }

    public void SecondPathPlacement()
    {
        GameObject go = secondPathArray[Random.Range(0, 10)];
        go.SetActive(true);
        go.transform.position = secondPathTransform.position + new Vector3(0, 0, 270);
    }

    public void ThirdPathPlacement()
    {
        GameObject go = thirdPathArray[Random.Range(0, 10)];
        go.SetActive(true);
        go.transform.position = thirdPathTransform.position + new Vector3(0, 0, 270);
    }

}
