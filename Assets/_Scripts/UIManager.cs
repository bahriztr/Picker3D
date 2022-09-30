using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField] public TMP_Text scoreText, levelText, nextLevelText;
    [SerializeField] public GameObject nextLevelMenu;
    [SerializeField] Image progressBarImage;
    private int score = 0;
    private float progress;

    public int Score { get => score; set => score = value; }

    private void Awake()
    {
        Instance = this;
    }

    public void SetProgress(float percentage)
    {
        print(percentage);
        progress = percentage;
        progressBarImage.DOFillAmount(progress / 100f, 1f);
    }

    public void IncreaseProgress(float increaseAmount = 33)
    {
        SetProgress(progress += increaseAmount);
    }

    public void ResetProgress()
    {
        progress = 0;
        progressBarImage.fillAmount = 0;
    }

    public void OpenNextLevelMenu()
    {
        nextLevelMenu.SetActive(true);
    }

    public void CloseNextLevelMenu()
    {
        nextLevelMenu.SetActive(false);
    }

    public void OnClickNextLevelButton()
    {
        CloseNextLevelMenu();
        Player.Instance.ToTargetArea();
        Player.Instance.SpeedUp();
    }

    public IEnumerator DelayForScoreCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        scoreText.text = score.ToString();
    }
}
