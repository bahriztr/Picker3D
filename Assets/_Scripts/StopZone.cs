using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //magnet toplad���m�z e�yalar� kovaya ittirmeli
        if (other.CompareTag("Player"))
            Player.Instance.PlayerSpeed = 0f;
    }
}
