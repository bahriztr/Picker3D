using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject[] firstPathArray, secondPathArray, thirdPathArray;

    public Transform firstPathTransform, secondPathTransform, thirdPathTransform;

    private GameObject go1, go2, go3;

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
        GameObject go1 = firstPathArray[Random.Range(0, 10)];
        go1.SetActive(true);
        go1.transform.position = firstPathTransform.position + new Vector3(0, 0, 270);
    }

    public void SecondPathPlacement()
    {
        GameObject go2 = secondPathArray[Random.Range(0, 10)];
        go2.SetActive(true);
        go2.transform.position = secondPathTransform.position + new Vector3(0, 0, 270);
    }

    public void ThirdPathPlacement()
    {
        GameObject go3 = thirdPathArray[Random.Range(0, 10)];
        go3.SetActive(true);
        go3.transform.position = thirdPathTransform.position + new Vector3(0, 0, 270);
    }

    public void FirstReUsePath(GameObject go)
    {
        if(firstPathArray[firstPathArray.Length - 1] == null)
        {
            go.transform.parent.gameObject.SetActive(false);
            firstPathArray[firstPathArray.Length - 1] = go.transform.parent.gameObject;
        }
    }
    public void SecondReUsePath(GameObject go)
    {
        if (secondPathArray[secondPathArray.Length - 1] == null)
        {
            secondPathArray[secondPathArray.Length - 1] = go.transform.parent.gameObject;
            go.transform.parent.gameObject.SetActive(false);
        }
    }
    public void ThirdReUsePath(GameObject go)
    {
        if (thirdPathArray[thirdPathArray.Length - 1] == null)
        {
            thirdPathArray[thirdPathArray.Length - 1] = go.transform.parent.gameObject;
            go.transform.parent.gameObject.SetActive(false);
        }
    }

}
