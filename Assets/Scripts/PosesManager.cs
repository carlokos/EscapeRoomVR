using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosesManager : MonoBehaviour
{
    [SerializeField] private GameObject poses;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
            poses.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
            poses.SetActive(false);
    }
}

