using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    public int levelCount
    {
        get
        {
            return PlayerPrefs.GetInt("level", 1);
        }
        set
        {
            PlayerPrefs.SetInt("level", value);
        }
    }

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        UIManager.Instance.levelText.text = levelCount.ToString();
        UIManager.Instance.nextLevelText.text = (levelCount + 1).ToString();
    }

    public void LevelUp()
    {
        levelCount++;
    }


}
