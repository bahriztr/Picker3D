using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.startPos += new Vector3(0, 0, 300);
            Player.Instance.SpeedDown();
            UIManager.Instance.OpenNextLevelMenu();
            LevelManager.Instance.LevelUp();
            UIManager.Instance.ResetProgress();
            Player.Instance.canPlayerMove = false;
        }
    }

   
}
