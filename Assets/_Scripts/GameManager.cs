using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject[] firstPathArray, secondPathArray, thirdPathArray;

    [HideInInspector] public Transform firstPathTransform, secondPathTransform, thirdPathTransform;

    private Vector3 addRoadDistance = new Vector3(0, 0, 3000);

    [HideInInspector] public int ballScore;

    public Vector3 startPos
    {
        get
        {
            return new Vector3(0, 0.5f, PlayerPrefs.GetFloat("startPosZ", -167.7f));
        }
        set
        {
            PlayerPrefs.SetFloat("startPosZ", value.z);
        }
    }

    private GameObject activeRoad;

    [SerializeField] Transform levelRoadsParent;

    public int setLevelTo;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        firstPathTransform = firstPathArray[0].transform;
        secondPathTransform = secondPathArray[0].transform;
        thirdPathTransform = thirdPathArray[0].transform;
    }

    public void FirstPathPlacement()
    {
        activeRoad = firstPathArray[Random.Range(1, 10)];
        activeRoad.transform.position = firstPathTransform.position + addRoadDistance;
        Instantiate(activeRoad, activeRoad.transform.position, Quaternion.identity);
    }

    public void SecondPathPlacement()
    {
        activeRoad = secondPathArray[Random.Range(1, 10)];
        activeRoad.transform.position = secondPathTransform.position + addRoadDistance;
        Instantiate(activeRoad, activeRoad.transform.position, Quaternion.identity);
    }

    public void ThirdPathPlacement()
    {
        activeRoad = thirdPathArray[Random.Range(1, 10)];
        activeRoad.transform.position = thirdPathTransform.position + addRoadDistance;
        Instantiate(activeRoad, activeRoad.transform.position, Quaternion.identity);
    }

    public void FirstReUsePath(GameObject go)
    {
        Destroy(go.transform.parent.gameObject);
        firstPathTransform = go.transform.parent.gameObject.transform;
    }
    public void SecondReUsePath(GameObject go)
    {
        Destroy(go.transform.parent.gameObject);
        secondPathTransform = go.transform.parent.gameObject.transform;
        
    }
    public void ThirdReUsePath(GameObject go)
    {
        Destroy(go.transform.parent.gameObject);
        thirdPathTransform = go.transform.parent.gameObject.transform;
        
    }
}
