using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Gates : MonoBehaviour
{
    public static Gates Instance; 
    [SerializeField] private GameObject firstRightGate, secondRightGate, thirdRightGate, firstLeftGate, secondLeftGate, thirdLeftGate;
    private Vector3 rightGatesRotateVec = new Vector3(0, 0, -90);
    private Vector3 leftGatesRotateVec = new Vector3(0, 0, 90);

    private void Awake()
    {
        Instance = this;
    }

    public void OpenFirstGates()
    {
        firstRightGate.transform.DORotate(rightGatesRotateVec, 1f);
        firstRightGate.transform.DOLocalMove(new Vector3(5.5f, 3.5f, firstRightGate.transform.localPosition.z), 1f);

        firstLeftGate.transform.DORotate(leftGatesRotateVec, 1f);
        firstLeftGate.transform.DOLocalMove(new Vector3(-5.5f, 3.5f, firstLeftGate.transform.localPosition.z), 1f);
    }
    public void OpenSecondGates()
    {
        secondRightGate.transform.DORotate(rightGatesRotateVec, 1f);
        secondRightGate.transform.DOLocalMove(new Vector3(5.5f, 3.5f, secondRightGate.transform.localPosition.z), 1f);

        secondLeftGate.transform.DORotate(leftGatesRotateVec, 1f);
        secondLeftGate.transform.DOLocalMove(new Vector3(-5.5f, 3.5f, secondLeftGate.transform.localPosition.z), 1f);
    }
    public void OpenThirdGates()
    {
        thirdRightGate.transform.DORotate(rightGatesRotateVec, 1f);
        thirdRightGate.transform.DOLocalMove(new Vector3(5.5f, 3.5f, thirdRightGate.transform.localPosition.z), 1f);

        thirdLeftGate.transform.DORotate(leftGatesRotateVec, 1f);
        thirdLeftGate.transform.DOLocalMove(new Vector3(-5.5f, 3.5f, thirdLeftGate.transform.localPosition.z), 1f);
    }
}
