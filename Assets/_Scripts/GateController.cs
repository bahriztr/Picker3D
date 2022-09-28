using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    public static GateController Instance;
    [SerializeField] private GateType gateType;
    private enum GateType
    {
        FirstGate,
        SecondGate,
        ThirdGate
    }

    private void Awake()
    {
        Instance = this;
    }

    public void GateControl()
    {
        if(gateType == GateType.FirstGate)
            Gates.Instance.OpenFirstGates();

        else if (gateType == GateType.SecondGate)
            Gates.Instance.OpenSecondGates();

        else
            Gates.Instance.OpenThirdGates();
    }
}
