using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDetect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FirstPath"))
        {
            GameManager.Instance.FirstPathPlacement();
            GameManager.Instance.FirstReUsePath(other.gameObject);
        }
        else if (other.CompareTag("SecondPath"))
        {
            GameManager.Instance.SecondPathPlacement();
            GameManager.Instance.SecondReUsePath(other.gameObject);
        }
        else if (other.CompareTag("ThirdPath"))
        {
            GameManager.Instance.ThirdPathPlacement();
            GameManager.Instance.ThirdReUsePath(other.gameObject);
        }
    }
}
