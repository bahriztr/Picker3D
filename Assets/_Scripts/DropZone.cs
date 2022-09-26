using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropZone : MonoBehaviour
{
    [SerializeField] private int requireScore;
    private int ballScore;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Collectible"))
        {
            ballScore++;
            UIManager.Instance.Score++;
            StartCoroutine(UIManager.Instance.DelayForScoreCoroutine());

            if(ballScore == requireScore)
            {
                //coroutine kullan belli bir saniye beklet
                //kapaklar açýlsýn
                //animasyonu oynat
                Player.Instance.PlayerSpeed = 8f;
                ballScore = 0;
            }

        }
    }
}
