using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        BallManager.Instance.PushBalls();

        if (other.CompareTag("Player"))
            Player.Instance.PlayerSpeed = 0f;
    }
}
