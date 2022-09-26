using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField] private TMP_Text scoreText;
    private int score = 0;

    public int Score { get => score; set => score = value; }

    private void Awake()
    {
        Instance = this;
    }

    public IEnumerator DelayForScoreCoroutine()
    {
        yield return new WaitForSeconds(1f);
        scoreText.text = score.ToString();
    }
}
