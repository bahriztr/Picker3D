using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject[] firstPathArray, secondPathArray, thirdPathArray;

    [HideInInspector] public Transform firstPathTransform, secondPathTransform, thirdPathTransform;

    private GameObject activeRoad;

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
        activeRoad = firstPathArray[Random.Range(0, 10)];
        activeRoad.SetActive(true);
        activeRoad.transform.position = firstPathTransform.position + new Vector3(0, 0, 270);
    }

    public void SecondPathPlacement()
    {
        activeRoad = secondPathArray[Random.Range(0, 10)];
        activeRoad.SetActive(true);
        activeRoad.transform.position = secondPathTransform.position + new Vector3(0, 0, 270);
    }

    public void ThirdPathPlacement()
    {
        activeRoad = thirdPathArray[Random.Range(0, 10)];
        activeRoad.SetActive(true);
        activeRoad.transform.position = thirdPathTransform.position + new Vector3(0, 0, 270);
    }

    public void FirstReUsePath(GameObject go)
    {
        if (firstPathArray[firstPathArray.Length - 1] == null)
        {
            firstPathArray[firstPathArray.Length - 1] = go.transform.parent.gameObject;
        }

        go.transform.parent.gameObject.SetActive(false);
        firstPathTransform = go.transform.parent.gameObject.transform;
    }
    public void SecondReUsePath(GameObject go)
    {
        if (secondPathArray[secondPathArray.Length - 1] == null)
        {
            secondPathArray[secondPathArray.Length - 1] = go.transform.parent.gameObject;
        }

        secondPathTransform = go.transform.parent.gameObject.transform;
        go.transform.parent.gameObject.SetActive(false);
    }
    public void ThirdReUsePath(GameObject go)
    {
        if (thirdPathArray[thirdPathArray.Length - 1] == null)
        {
            thirdPathArray[thirdPathArray.Length - 1] = go.transform.parent.gameObject;
        }

        go.transform.parent.gameObject.SetActive(false);
        thirdPathTransform = go.transform.parent.gameObject.transform;
    }

}
