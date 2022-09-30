using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropZone : MonoBehaviour
{
    private Animator animator;

    [SerializeField] private TMP_Text requireText, ballText;

    [SerializeField] private int requireScore;

    public int RequireScore { get => requireScore; }

    bool isPartCompleted;

    private void Start()
    {
        requireText.text = "/ " + requireScore.ToString();
        animator = transform.GetComponentInParent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Collectible"))
        {
            GameManager.Instance.ballScore++;
            UIManager.Instance.Score++;
            ballText.text = GameManager.Instance.ballScore.ToString();
            StartCoroutine(UIManager.Instance.DelayForScoreCoroutine());

            if(BallManager.Instance.BallList.Count == 0 && !isPartCompleted)
                StartCoroutine(DelayForWinOrLoseScreenCoroutine());
        }
    }

    IEnumerator DelayForWinOrLoseScreenCoroutine()
    {
        isPartCompleted = true;
        yield return new WaitForSeconds(0.5f);

        if (GameManager.Instance.ballScore >= requireScore)
        {
            StartCoroutine(DelayForDropZoneCoroutine());
            UIManager.Instance.IncreaseProgress();
        }
    }

    IEnumerator DelayForDropZoneCoroutine()
    {
        yield return new WaitForSeconds(1f);
        BallManager.Instance.BlastAllBalls();

        yield return new WaitForSeconds(1.2f);
        transform.GetChild(0).gameObject.SetActive(true);

        yield return new WaitForSeconds(1.3f);
        animator.SetBool("GateTrigger",true);

        yield return new WaitForSeconds(1.5f);
        Player.Instance.SpeedUp();
        GameManager.Instance.ballScore = 0;

    }
}
