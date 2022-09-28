using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropZone : MonoBehaviour
{
    [SerializeField] private int requireScore;
    private int ballScore;
    public bool isCoroutine;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Collectible"))
        {
            ballScore++;
            UIManager.Instance.Score++;
            StartCoroutine(UIManager.Instance.DelayForScoreCoroutine());

            if(ballScore == requireScore)
            {
                //kapaklar açýlsýn
                StartCoroutine(DelayForDropZoneCoroutine());
                ballScore = 0;
            }
        }
    }

    IEnumerator DelayForDropZoneCoroutine()
    {
        yield return new WaitForSeconds(0.6f);
        BallManager.Instance.BlastAllBalls();

        yield return new WaitForSeconds(0.8f);
        transform.GetChild(0).gameObject.SetActive(true);

        yield return new WaitForSeconds(0.9f);
        GateController.Instance.GateControl();

        yield return new WaitForSeconds(1.1f);
        Player.Instance.SpeedUp();

        yield return new WaitForSeconds(1.3f);
        BallManager.Instance.BallList.Clear();
    }
}
