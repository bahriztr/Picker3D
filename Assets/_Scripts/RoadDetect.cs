using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDetect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FirstPath"))
        {
            GameManager.Instance.FirstReUsePath(other.gameObject);
        }

        else if (other.CompareTag("SecondPath"))
        {
            GameManager.Instance.SecondReUsePath(other.gameObject);
        }

        else if (other.CompareTag("ThirdPath"))
        {
            GameManager.Instance.FirstPathPlacement();
            GameManager.Instance.SecondPathPlacement();
            GameManager.Instance.ThirdPathPlacement();
            GameManager.Instance.ThirdReUsePath(other.gameObject);
        }

    }

}

